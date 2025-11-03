using System.Collections.Generic;
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
    public bool NPCTrigger;

    [Header("Player Animations:")]
    public Animator Anim;
    public SpriteRenderer SpriteRender;

    [Header("Player Hunger: ")]
    public bool TimerStart;
    public float Timer;
    public Image HealthSanityBar;
    public bool IsMoving = false;

    public bool IsFood = false;

    public GameObject TesterScreen;
    public GameObject MadTesterScreen;

    public GameManagerScripts GameManager;
    private NPCFoodScript NPCFood;

    [Header("Player Inventory: ")]
    public List<string> Inventory = new List<string>();

    CollectibleScript Collectible;

    public bool IsCollectible = false;

    public int InventoryCount = 2;

    public GameObject InfoPanel;

    private void Start()
    {
        if (Anim == null)
        {
            Anim = GetComponent<Animator>();
        }

        SpriteRender = GetComponent<SpriteRenderer>();

        GameManager.SanityHigh = true;
        GameManager.SanityLow = false;

        Cursor.visible = false;
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

        Vector2 movementDirection = movement.normalized;

        if (movementDirection.x > 0.1f)
        {
            SpriteRender.flipX = false;
            Anim.SetBool("SideWalk", true);
        }
        else if (movementDirection.x < -0.1f)
        {
            SpriteRender.flipX = true;
            Anim.SetBool("SideWalk", true);
        }
        else
        {
            Anim.SetBool("SideWalk", false);
        }

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
                    Timer = 45f;
                    TimerStart = false;
                }
            }

        }
        else if (!IsMoving) 
        {
            TimerStart = false;
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

            Timer = 60f;

            GameManager.SanityLow = true;
            GameManager.SanityHigh = false;

        }
        else if (HealthSanityBar.fillAmount >= 0.17f)
        {
            if (HealthSanityBar.fillAmount >= 0.5f)
            {
                TesterScreen.SetActive(false);
            }
            MadTesterScreen.SetActive(false);
            GameManager.SanityLow = false;
            GameManager.SanityHigh = true;

        }

        
        if (NPCFood != null)
        {
            if (NPCFood.PlayerNear)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (HealthSanityBar.fillAmount != 1.0f)
                    {
                        NPCFood.Eaten();
                        HealthSanityBar.fillAmount += 0.5f;
                        Timer = 15f;
                    }
                }
            }

        }

        if (Collectible != null)
        {
            if (Collectible.PlayerNear)
            {
                if (Input.GetKeyDown(KeyCode.E) && Collectible.Edible)
                {
                    if (HealthSanityBar.fillAmount != 1.0f)
                    {
                        Collectible.Eaten();
                        HealthSanityBar.fillAmount += 0.5f;
                        Timer = 15f;
                    }
                }


                if (Input.GetKeyDown(KeyCode.F))
                {
                    {
                        // Inventory Check
                        if (Inventory.Count == InventoryCount)
                        {
                            InfoPanel.SetActive(true);
                            Cursor.visible = true;
                            Debug.Log("Hands are full");
                        }
                        else
                        {
                            //Add to Inventory
                            Inventory.Add(Collectible.ObjectName);
                            // Collectible.Eaten();*/
                            Collectible.CollectItem();
                        }

                    }
                }
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            NPCTrigger = true;
        }

        if (collision.CompareTag("Collectable"))
        {
            Collectible = collision.gameObject.GetComponent<CollectibleScript>();
            IsFood = true;
            NPCFood = collision.gameObject.GetComponent<NPCFoodScript>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            NPCTrigger = false;
        }

        if (collision.CompareTag("Collectable"))
        {
            IsFood = false;
        }
    }
}
