using System.Collections;
using TMPro;
using UnityEngine;

public class TreeHouseScript : MonoBehaviour
{
    public PlayerMovement Inventory;

    public GameObject ChoicePanel;

    public DialogueAsset Player1;
    public DialogueAsset Player2;
    public DialogueAsset Player3;

    public TabbyDialogueManager Manager;

    public GameObject CursedDoll;
    public InventoryController InventoryControl;

    public GameObject Trigger;

    public bool PlayerNear;

    [Header("Dialogue Management: ")]
    public GameObject DialoguePanel;
    public TMP_Text DialogueText;
    public TMP_Text QuestText;

    public GameObject Dolls;

    public AudioSource FirstSound;
    public AudioSource SecondSound;
    public AudioSource CompleteQuestSFX;

    private void Update()
    {
        if (PlayerNear && Input.GetKeyDown(KeyCode.F))
        {
            ChoicePanel.SetActive(true);
            Time.timeScale = 0f;
            Cursor.visible = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string foundItem = null;
        foreach (string item in Inventory.Inventory)
        {
            if (item == "Creepy Doll")
            {
                foundItem = item;
                break;
            }
        }

        if (collision.CompareTag("Player") && foundItem != null)
        {
            PlayerNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerNear = false;
        }
    }

    public void PlaceDoll()
    {
        ChoicePanel.SetActive(false);
        DialoguePanel.SetActive(true);
        DisplayDialogue1(Player1);
    }

    IEnumerator MoveThroughDialogue1(DialogueAsset dialogue) //1
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        FirstSound.Play();
        DisplayDialogue2(Player2);
    }


    IEnumerator MoveThroughDialogue2(DialogueAsset dialogue) //2
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        SecondSound.Play();  
        DisplayDialogue3(Player3);
    }

    IEnumerator MoveThroughDialogue3(DialogueAsset dialogue) //3
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        Time.timeScale = 1.0f;
 
        DialoguePanel.SetActive(false);
        Cursor.visible = false;
        CursedDoll.SetActive(true);

        string foundItem = null;
        foreach (string item in Inventory.Inventory)
        {
            if (item == "Creepy Doll")
            {
                foundItem = item;
                break;
            }
        }

        Inventory.Inventory.Remove(foundItem);
        InventoryControl.RemoveItemsFromInventory(7);

        QuestText.text = "Return to Tabby and Baby Carni";

        Manager.QuestInProgress = true;
        Manager.QuestStarted = false;

        Trigger.SetActive(false);

        Dolls.SetActive(true);

        CompleteQuestSFX.Play();

    }

    public void DisplayDialogue1(DialogueAsset dialogue) //1
    {
        StartCoroutine(MoveThroughDialogue1(dialogue));
    }

    public void DisplayDialogue2(DialogueAsset dialogue) //2
    {
        StartCoroutine(MoveThroughDialogue2(dialogue));
    }

    public void DisplayDialogue3(DialogueAsset dialogue) //3
    {
        StartCoroutine(MoveThroughDialogue3(dialogue));
    }
}
