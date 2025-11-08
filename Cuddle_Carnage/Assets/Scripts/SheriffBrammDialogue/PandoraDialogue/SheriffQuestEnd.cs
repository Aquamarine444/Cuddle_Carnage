using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SheriffQuestEnd : MonoBehaviour
{
    [Header("Text: ")]
    [SerializeField] private TMP_Text DialogueText;
    [SerializeField] private TMP_Text QuestText;

    public GameObject Items;
    public GameObject Info;

    [Header("Characters: ")]
    public GameObject Pandora;
    public GameObject Player;
    public GameObject PandoraName;
    public GameObject DialoguePanel;

    public GameObject SheriffImage;
    public GameObject SheriffName;

    [Header("Dialgoue Assets: ")]
    public DialogueAsset Player1; //1
    public DialogueAsset Pandora1; //2
    public DialogueAsset Player2; //3
    public DialogueAsset Pandora2; //4
    public DialogueAsset Player3; //5
    public DialogueAsset Pandora3; //6
    public DialogueAsset Player4; //7
    public DialogueAsset Pandora4; //8
    public DialogueAsset Player5; //9
    public DialogueAsset Pandora5; //10
    public DialogueAsset Player6; //11
    public DialogueAsset Pandora6; //12
    public DialogueAsset Player7; //13
    public DialogueAsset Pandora7; //14
    public DialogueAsset Player8; //15
    public DialogueAsset Pandora8; //16
    public DialogueAsset Player9; //17
    public DialogueAsset Player10; //18
    public DialogueAsset Pandora9; //19
    public DialogueAsset Player11; //20
    public DialogueAsset Pandora10; //21
    public DialogueAsset Player12; //22
    public DialogueAsset Pandora11; //23
    public DialogueAsset Player13; //24
    public DialogueAsset Pandora12; //25
    public DialogueAsset Player14; //26
    public DialogueAsset Pandora13; //27
    public DialogueAsset Player15; //28
    public DialogueAsset Pandora14; //29
    public DialogueAsset Player16; //30
    public DialogueAsset Pandora15; //31
    public DialogueAsset Player17; //32

    [Header("Pandora General Dialogue: ")]
    public DialogueAsset PandoraGeneral11;
    public DialogueAsset PandoraGeneral12;
    public DialogueAsset PandoraGeneral13;
    public DialogueAsset PandoraGeneral14;
    public DialogueAsset PandoraGeneral2;

    [Header("Extra: ")]
    public bool QuestComplete;
    public SheriffDialogueManager SheriffDialogue;
    public NPCScript NPCManager;

    public GameObject DialogueScript;
    public GameManagerScripts GameManager;

    public GameObject PandoraAvatar;
    public GameObject PandoraFluff;
    public GameObject Kite;
    public GameObject KiteTree;
    public GameObject NormalTree;

    public SpriteRenderer PandoraSkin;
    public Sprite PandoraKite;

    public GameObject BlackScreen;

    public InventoryController Inventory;
    public PlayerMovement InventoryCheck;

    public Button QuestButton;

    public GameObject SheriffDialoguePanel;

    public GameObject Sheriff;

    public AudioSource CompleteQuestSFX;

    private void Update()
    {
        if (SheriffDialogue.QuestStarted && NPCManager.PlayerNear && !QuestComplete && Input.GetKeyDown(KeyCode.F))
        {
            Time.timeScale = 0f;
            DialoguePanel.SetActive(true);
            Items.SetActive(false);
            Info.SetActive(true);

            DialogueScript.SetActive(true);

            Player.SetActive(true);
            PandoraName.SetActive(false);
            Pandora.SetActive(false);

            SheriffDialoguePanel.SetActive(false);

            Cursor.visible = true;

            SheriffDialogue.QuestStarted = false;   

            DisplayDialogue1(Player1);
        }

        if (Sheriff.activeInHierarchy)
        {
            if (GameManager.PandoraQuest && Input.GetKeyDown(KeyCode.F) && NPCManager.PlayerNear)
            {
                Time.timeScale = 0f;
                DialoguePanel.SetActive(true);
                Items.SetActive(false);
                Info.SetActive(true);

                DialogueScript.SetActive(true);
                Pandora.SetActive(true);
                PandoraName.SetActive(true);

                Cursor.visible = true;

                DisplayDialogueG11(PandoraGeneral11);
            }
        }
        else if (!Sheriff.activeInHierarchy)
        {
            if (GameManager.PandoraQuest && Input.GetKeyDown(KeyCode.F) && NPCManager.PlayerNear)
            {
                Time.timeScale = 0f;
                DialoguePanel.SetActive(true);
                Items.SetActive(false);
                Info.SetActive(true);

                DialogueScript.SetActive(true);
                Pandora.SetActive(true);
                PandoraName.SetActive(true);

                Cursor.visible = true;

                DisplayDialogueG2(PandoraGeneral2);
            }
        }

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

        Pandora.SetActive(true);
        PandoraName.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue2(Pandora1);
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

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue3(Player2);
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

        Pandora.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue4(Pandora2);
    }

    IEnumerator MoveThroughDialogue4(DialogueAsset dialogue) //4
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue5(Player3);
    }

    IEnumerator MoveThroughDialogue5(DialogueAsset dialogue) //5
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue6(Pandora3);
    }

    IEnumerator MoveThroughDialogue6(DialogueAsset dialogue) //6
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue7(Player4);
    }

    IEnumerator MoveThroughDialogue7(DialogueAsset dialogue) //7
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue8(Pandora4);
    }

    IEnumerator MoveThroughDialogue8(DialogueAsset dialogue) //8
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue9(Player5);
    }

    IEnumerator MoveThroughDialogue9(DialogueAsset dialogue) //9
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue10(Pandora5);
    }

    IEnumerator MoveThroughDialogue10(DialogueAsset dialogue) //10
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue11(Player6);
    }

    IEnumerator MoveThroughDialogue11(DialogueAsset dialogue) //11
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue12(Pandora6);
    }

    IEnumerator MoveThroughDialogue12(DialogueAsset dialogue) //12
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue13(Player7);
    }

    IEnumerator MoveThroughDialogue13(DialogueAsset dialogue) //13
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue14(Pandora7);
    }

    IEnumerator MoveThroughDialogue14(DialogueAsset dialogue) //14
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue15(Player8);
    }

    IEnumerator MoveThroughDialogue15(DialogueAsset dialogue) //15
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue16(Pandora8);
    }

    IEnumerator MoveThroughDialogue16(DialogueAsset dialogue) //16
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue17(Player9);
    }

    IEnumerator MoveThroughDialogue17(DialogueAsset dialogue) //17
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);
        BlackScreen.SetActive(true);

        DisplayDialogue18(Player10);
    }

    IEnumerator MoveThroughDialogue18(DialogueAsset dialogue) //18
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue19(Pandora9);
    }

    IEnumerator MoveThroughDialogue19(DialogueAsset dialogue) //19
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue20(Player11);
    }

    IEnumerator MoveThroughDialogue20(DialogueAsset dialogue) //20
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        Player.SetActive(false);

        BlackScreen.SetActive(false);
        Kite.SetActive(true);
        KiteTree.SetActive(false);
        NormalTree.SetActive(true);

        DisplayDialogue21(Pandora10);
    }

    IEnumerator MoveThroughDialogue21(DialogueAsset dialogue) //21
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue22(Player12);
    }

    IEnumerator MoveThroughDialogue22(DialogueAsset dialogue) //22
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue23(Pandora11);
    }

    IEnumerator MoveThroughDialogue23(DialogueAsset dialogue) //23
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue24(Player13);
    }

    IEnumerator MoveThroughDialogue24(DialogueAsset dialogue) //24
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue25(Pandora12);
    }

    IEnumerator MoveThroughDialogue25(DialogueAsset dialogue) //25
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue26(Player14);
    }

    IEnumerator MoveThroughDialogue26(DialogueAsset dialogue) //26
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue27(Pandora13);
    }

    IEnumerator MoveThroughDialogue27(DialogueAsset dialogue) //27
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue28(Player15);
    }

    IEnumerator MoveThroughDialogue28(DialogueAsset dialogue) //28
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue29(Pandora14);
    }

    IEnumerator MoveThroughDialogue29(DialogueAsset dialogue) //29
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue30(Player16);
    }

    IEnumerator MoveThroughDialogue30(DialogueAsset dialogue) //30
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue31(Pandora15);
    }

    IEnumerator MoveThroughDialogue31(DialogueAsset dialogue) //31
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue32(Player17);
    }

    IEnumerator MoveThroughDialogue32(DialogueAsset dialogue) //32
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        QuestComplete = true;

        Pandora.SetActive(true);
        PandoraName.SetActive(false);
        Player.SetActive(false);

        Time.timeScale = 1.0f;
        DialoguePanel.SetActive(false);
        QuestText.text = "No Active Quest";

        Cursor.visible = false;
        DialogueScript.SetActive(true);

        Kite.SetActive(false);

        PandoraAvatar.transform.position = new Vector2(-9.84f, -40.86f);
        PandoraFluff.transform.position = new Vector2(-9.84f, -40.86f);

        //Inventory.slotCount += 2;
        InventoryCheck.InventoryCount += 2;
        GameManager.PandoraQuest = true;
        GameManager.QuestCounter += 1;
        QuestButton.interactable = false;

        Inventory.SetInventoryItems(Inventory.GetInventoryItems());
        GameManager.QuestCounter += 1;

        PandoraSkin.sprite = PandoraKite;

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

    public void DisplayDialogue4(DialogueAsset dialogue) //4
    {
        StartCoroutine(MoveThroughDialogue4(dialogue));
    }

    public void DisplayDialogue5(DialogueAsset dialogue) //5
    {
        StartCoroutine(MoveThroughDialogue5(dialogue));
    }

    public void DisplayDialogue6(DialogueAsset dialogue) //6
    {
        StartCoroutine(MoveThroughDialogue6(dialogue));
    }

    public void DisplayDialogue7(DialogueAsset dialogue) //7
    {
        StartCoroutine(MoveThroughDialogue7(dialogue));
    }

    public void DisplayDialogue8(DialogueAsset dialogue) //8
    {
        StartCoroutine(MoveThroughDialogue8(dialogue));
    }

    public void DisplayDialogue9(DialogueAsset dialogue) //9
    {
        StartCoroutine(MoveThroughDialogue9(dialogue));
    }

    public void DisplayDialogue10(DialogueAsset dialogue) //10
    {
        StartCoroutine(MoveThroughDialogue10(dialogue));
    }

    public void DisplayDialogue11(DialogueAsset dialogue) //11
    {
        StartCoroutine(MoveThroughDialogue11(dialogue));
    }

    public void DisplayDialogue12(DialogueAsset dialogue) //12
    {
        StartCoroutine(MoveThroughDialogue12(dialogue));
    }

    public void DisplayDialogue13(DialogueAsset dialogue) //13
    {
        StartCoroutine(MoveThroughDialogue13(dialogue));
    }

    public void DisplayDialogue14(DialogueAsset dialogue) //14
    {
        StartCoroutine(MoveThroughDialogue14(dialogue));
    }

    public void DisplayDialogue15(DialogueAsset dialogue) //15
    {
        StartCoroutine(MoveThroughDialogue15(dialogue));
    }

    public void DisplayDialogue16(DialogueAsset dialogue) //16
    {
        StartCoroutine(MoveThroughDialogue16(dialogue));
    }

    public void DisplayDialogue17(DialogueAsset dialogue) //17
    {
        StartCoroutine(MoveThroughDialogue17(dialogue));
    }

    public void DisplayDialogue18(DialogueAsset dialogue) //18
    {
        StartCoroutine(MoveThroughDialogue18(dialogue));
    }

    public void DisplayDialogue19(DialogueAsset dialogue) //19
    {
        StartCoroutine(MoveThroughDialogue19(dialogue));
    }

    public void DisplayDialogue20(DialogueAsset dialogue) //20
    {
        StartCoroutine(MoveThroughDialogue20(dialogue));
    }

    public void DisplayDialogue21(DialogueAsset dialogue) //21
    {
        StartCoroutine(MoveThroughDialogue21(dialogue));
    }

    public void DisplayDialogue22(DialogueAsset dialogue) //22
    {
        StartCoroutine(MoveThroughDialogue22(dialogue));
    }

    public void DisplayDialogue23(DialogueAsset dialogue) //23
    {
        StartCoroutine(MoveThroughDialogue23(dialogue));
    }

    public void DisplayDialogue24(DialogueAsset dialogue) //24
    {
        StartCoroutine(MoveThroughDialogue24(dialogue));
    }

    public void DisplayDialogue25(DialogueAsset dialogue) //25
    {
        StartCoroutine(MoveThroughDialogue25(dialogue));
    }

    public void DisplayDialogue26(DialogueAsset dialogue) //26
    {
        StartCoroutine(MoveThroughDialogue26(dialogue));
    }

    public void DisplayDialogue27(DialogueAsset dialogue) //27
    {
        StartCoroutine(MoveThroughDialogue27(dialogue));
    }

    public void DisplayDialogue28(DialogueAsset dialogue) //28
    {
        StartCoroutine(MoveThroughDialogue28(dialogue));
    }

    public void DisplayDialogue29(DialogueAsset dialogue) //29
    {
        StartCoroutine(MoveThroughDialogue29(dialogue));
    }

    public void DisplayDialogue30(DialogueAsset dialogue) //30
    {
        StartCoroutine(MoveThroughDialogue30(dialogue));
    }

    public void DisplayDialogue31(DialogueAsset dialogue) //31
    {
        StartCoroutine(MoveThroughDialogue31(dialogue));
    }

    public void DisplayDialogue32(DialogueAsset dialogue) //32
    {
        StartCoroutine(MoveThroughDialogue32(dialogue));
    }

    /////////////////////General Dialogue////////////////////////

    IEnumerator MoveThroughDialogueG11(DialogueAsset dialogue) //G11
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        PandoraName.SetActive(false);
        SheriffImage.SetActive(true);
        SheriffName.SetActive(true);

        DisplayDialogueG12(PandoraGeneral12);
    }

    IEnumerator MoveThroughDialogueG12(DialogueAsset dialogue) //G12
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        PandoraName.SetActive(true);
        SheriffImage.SetActive(false);
        SheriffName.SetActive(false);

        DisplayDialogueG13(PandoraGeneral13);
    }

    IEnumerator MoveThroughDialogueG13(DialogueAsset dialogue) //G13
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(false);
        PandoraName.SetActive(false);
        SheriffImage.SetActive(true);
        SheriffName.SetActive(true);

        DisplayDialogueG14(PandoraGeneral14);
    }

    IEnumerator MoveThroughDialogueG14(DialogueAsset dialogue) //G14
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        PandoraName.SetActive(false);
        SheriffImage.SetActive(false);

        Time.timeScale = 1.0f;
        DialoguePanel.SetActive(false);
        Cursor.visible = false;
    }

    public void DisplayDialogueG11(DialogueAsset dialogue) //G11
    {
        StartCoroutine(MoveThroughDialogueG11(dialogue));
    }

    public void DisplayDialogueG12(DialogueAsset dialogue) //G12
    {
        StartCoroutine(MoveThroughDialogueG12(dialogue));
    }

    public void DisplayDialogueG13(DialogueAsset dialogue) //G13
    {
        StartCoroutine(MoveThroughDialogueG13(dialogue));
    }

    public void DisplayDialogueG14(DialogueAsset dialogue) //G14
    {
        StartCoroutine(MoveThroughDialogueG14(dialogue));
    }

    IEnumerator MoveThroughDialogueG2(DialogueAsset dialogue) //G2
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

        Pandora.SetActive(true);
        PandoraName.SetActive(false);
        Player.SetActive(false);

        Time.timeScale = 1.0f;
        DialoguePanel.SetActive(false);
        Cursor.visible = false;
    }

    public void DisplayDialogueG2(DialogueAsset dialogue) //G2
    {
        StartCoroutine(MoveThroughDialogueG2(dialogue));
    }

}
