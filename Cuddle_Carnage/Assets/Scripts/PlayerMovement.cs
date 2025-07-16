using System.Diagnostics.Contracts;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public InputActionAsset PlayerAction;
    private InputAction moveAction;
    private Vector2 moveInput;

    [Header("NPC Interactions:")]
    public GameObject PopupText;
    public bool NPCTrigger;
    public GameObject NPCPanel;

    public GameObject TesterNPC;
    public GameObject TesterFoodNPC;
    public GameObject TesterFluffNPC; //add onto NPC script?

    [Header("Player Hunger: ")]
    public bool TimerStart;
    public float Timer;
    public Image HealthSanityBar;
    public bool IsMoving = false;

    public bool IsFood = false;
    public GameObject Food;

    public GameObject TesterScreen;
    public GameObject MadTesterScreen;

    private void FixedUpdate()
    {
        if (NPCTrigger)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                NPCPanel.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
    }

    private void OnEnable()
    {
        // Find the action map and move action
        var actionMap = PlayerAction.FindActionMap("MainPlayer");
        moveAction = actionMap.FindAction("Movement");

        // Enable input actions
        actionMap.Enable();
        moveAction.Enable();

        // Subscribe to input performed/canceled events
        moveAction.performed += OnMove;
        moveAction.canceled += OnMoveCancelled;
    }

    private void OnDisable()
    {
        // Disable input actions and unsubscribe events
        moveAction.performed -= OnMove; // This listens for when the player presses a movement key like a or d
        moveAction.canceled -= OnMoveCancelled; // This listens for when the player releases the key

        moveAction.Disable();
        // It turns off the input action - Unity will stop listening for that specific input.Improves performance by stopping unnecessary input checks.
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        // Read movement input from the player when performed ^
        moveInput = context.ReadValue<Vector2>();

        IsMoving = true;
    }
    private void OnMoveCancelled(InputAction.CallbackContext context)
    {
        // Reset movement when input is cancelled ^
        moveInput = Vector2.zero;

        IsMoving = false;
    }
    private void Update()
    {
        // Apply movement based on input
        Vector2 movement = new Vector2(moveInput.x, moveInput.y) * Speed * Time.deltaTime;
        transform.Translate(movement);

        if (IsMoving)
        {
            TimerStart = true;
            if (TimerStart == true)
            {
                if (Timer > 0)
                {
                    Timer -= Time.deltaTime;
                }
                else if (Timer <= 0)
                {
                    HealthSanityBar.fillAmount = HealthSanityBar.fillAmount - 0.17f;
                    Timer = 15f;
                    TimerStart = false;
                }
            }

        }
        else if (!IsMoving) 
        {
            TimerStart = false;
        }

        if (IsFood)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (HealthSanityBar.fillAmount != 1.0f)
                {
                    Food.SetActive(false);
                    HealthSanityBar.fillAmount += 0.5f;
                    Timer = 15f;
                }
                else
                {
                    //replace with script to allow option to place food in inventory
                    Debug.Log("Can't eat now");
                }
            }
        }

        if (HealthSanityBar.fillAmount <= 0.5f)
        {
            TesterScreen.SetActive(true);
        }
        else if (HealthSanityBar.fillAmount > 0.5f)
        {
            TesterScreen.SetActive(false);
        }

        if (HealthSanityBar.fillAmount <= 0.16f)
        {
            MadTesterScreen.SetActive(true);

            Timer = 30f;

            TesterNPC.SetActive(false);
            TesterFoodNPC.SetActive(true); 
        }
        else if (HealthSanityBar.fillAmount >= 0.17f)
        {
            if (HealthSanityBar.fillAmount >= 0.5f)
            {
                TesterScreen.SetActive(false);
            }
            MadTesterScreen.SetActive(false);
            //TesterFluffNPC.SetActive(true); --- Causes error when loading the game
            TesterFoodNPC.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            PopupText.SetActive(true);
            NPCTrigger = true;
        }

        if (collision.CompareTag("Food"))
        {
            IsFood = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            PopupText.SetActive(false);
            NPCTrigger = false;
        }

        if (collision.CompareTag("Food"))
        {
            IsFood = false;
        }
    }
}
