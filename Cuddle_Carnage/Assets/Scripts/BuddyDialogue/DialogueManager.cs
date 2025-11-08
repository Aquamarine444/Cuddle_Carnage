using UnityEngine;
using UnityEngine.InputSystem;
using Unity.VisualScripting;
using TMPro;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using JetBrains.Annotations;

public class DialogueManager : MonoBehaviour
{
    [Header("Text: ")]
    [SerializeField] private TMP_Text DialogueText;
    [SerializeField] private TMP_Text QuestText;

    public GameObject BuddyName;
    public GameObject Items;
    public GameObject Info;

    [Header("Characters: ")]
    public GameObject Buddy;
    public GameObject Player;
    public GameObject PlayerName;
    public GameObject DialoguePanel;


    [Header("DialogueLines: ")]
    public DialogueAsset Player1Dialogue; //1
    public DialogueAsset Buddy1Dialogue; //2
    public DialogueAsset Player2Dialogue; //3
    public DialogueAsset Buddy2Dialogue; //4
    public DialogueAsset Player3Dialogue; //5
    public DialogueAsset Buddy3Dialogue; //6
    public DialogueAsset Player4Dialogue; //7
    public DialogueAsset Buddy4Dialogue; //8
    public DialogueAsset Player5Dialogue; //9
    public DialogueAsset Buddy5Dialogue; //10 
    public DialogueAsset Player6Dialogue; //11
    public DialogueAsset Buddy6Dialogue; //12
    public DialogueAsset Player7Dialogue; //13

    [Header("DialogueLines Part2")]
    public DialogueAsset Buddy21Dialogue; //1
    public DialogueAsset Player21Dialogue; //2
    public DialogueAsset Buddy22Dialogue; //3
    public DialogueAsset Player22Dialogue; //4
    public DialogueAsset Buddy23Dialogue; //5
    public DialogueAsset Player23Dialogue; //6
    public DialogueAsset Buddy24Dialogue; //7
    public DialogueAsset Player24Dialogue; //8
    public DialogueAsset Buddy25Dialogue; //9
    public DialogueAsset Player25Dialogue; //10 
    public DialogueAsset Buddy26Dialogue; //11
    public DialogueAsset Player26Dialogue; //12
    public DialogueAsset Buddy27Dialogue; //13
    public DialogueAsset Player27Dialogue; //14

    [Header("DialogueLines General")]
    public DialogueAsset BuddyG1Dialogue; //1
    public DialogueAsset PlayerG1Dialogue; //2
    public DialogueAsset BuddyG2Dialogue; //3
    public DialogueAsset PlayerG2Dialogue; //4

    [Header("Extra: ")]
    public bool BuddyQuestStarted;
    public Button QuestButton;
    public GameObject DialogueScript;
    public GameManagerScripts GameManager;
    public GameObject Food;

    public GameObject Sheriff;

    public AudioSource QuestCompleteSFX;


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
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);

        DisplayDialogue2(Buddy1Dialogue);
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
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);

        DisplayDialogue3(Player2Dialogue);
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
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);

        DisplayDialogue4(Buddy2Dialogue);
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
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);

        DisplayDialogue5(Player3Dialogue);
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
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);

        DisplayDialogue6(Buddy3Dialogue);
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
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);

        DisplayDialogue7(Player4Dialogue);
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
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);

        DisplayDialogue8(Buddy4Dialogue);
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
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);

        DisplayDialogue9(Player5Dialogue);
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
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);

        DisplayDialogue10(Buddy5Dialogue);
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
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);

        DisplayDialogue11(Player6Dialogue);
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
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);

        DisplayDialogue12(Buddy6Dialogue);
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
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);

        DisplayDialogue13(Player7Dialogue);
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
        Player.SetActive(false);
        PlayerName.SetActive(false);
        Time.timeScale = 1.0f;
        DialoguePanel.SetActive(false);
        QuestText.text = "Enter and Explore the Cave of Terrible Terrors";
        BuddyQuestStarted = true;
        Cursor.visible = false;
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

    /////////////////////////////////After Quest///////////////

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
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);

        DisplayDialogue22(Player21Dialogue);
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
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);

        DisplayDialogue23(Buddy22Dialogue);
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
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);

        DisplayDialogue24(Player22Dialogue);
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
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);

        DisplayDialogue25(Buddy23Dialogue);
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
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);

        DisplayDialogue26(Player23Dialogue);
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
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);

        DisplayDialogue27(Buddy24Dialogue);
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
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);

        DisplayDialogue28(Player24Dialogue);
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
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);

        DisplayDialogue29(Buddy25Dialogue);
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
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);

        DisplayDialogue210(Player25Dialogue);
    }

    IEnumerator MoveThroughDialogue210(DialogueAsset dialogue) //210
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);

        DisplayDialogue211(Buddy26Dialogue);
    }

    IEnumerator MoveThroughDialogue211(DialogueAsset dialogue) //211
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);

        DisplayDialogue212(Player26Dialogue);
    }

    IEnumerator MoveThroughDialogue212(DialogueAsset dialogue) //212
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);

        DisplayDialogue213(Buddy27Dialogue);
    }

    IEnumerator MoveThroughDialogue213(DialogueAsset dialogue) //213
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);

        DisplayDialogue214(Player27Dialogue);
    }

    IEnumerator MoveThroughDialogue214(DialogueAsset dialogue) //214
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);
        Time.timeScale = 1.0f;
        DialoguePanel.SetActive(false);
        QuestText.text = "No Active Quests";

        QuestButton.interactable = false;
        BuddyName.SetActive(false);
        Info.SetActive(false);

        Sheriff.SetActive(true);
        Food.SetActive(true);

        Items.SetActive(true);
        DialogueScript.SetActive(false);

        Cursor.visible = false;
        GameManager.BuddyQuest = true;
        GameManager.QuestCounter += 1;

        QuestCompleteSFX.Play();
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

    public void DisplayDialogue210(DialogueAsset dialogue) //210
    {
        StartCoroutine(MoveThroughDialogue210(dialogue));
    }

    public void DisplayDialogue211(DialogueAsset dialogue) //211
    {
        StartCoroutine(MoveThroughDialogue211(dialogue));
    }

    public void DisplayDialogue212(DialogueAsset dialogue) //212
    {
        StartCoroutine(MoveThroughDialogue212(dialogue));
    }

    public void DisplayDialogue213(DialogueAsset dialogue) //213
    {
        StartCoroutine(MoveThroughDialogue213(dialogue));
    }

    public void DisplayDialogue214(DialogueAsset dialogue) //214
    {
        StartCoroutine(MoveThroughDialogue214(dialogue));
    }


    ///////////////////////////General Dialogue/////////////////////////

    IEnumerator MoveThroughDialogueG1(DialogueAsset dialogue) //G1
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Buddy.SetActive(false);
        BuddyName.SetActive(false);

        DisplayDialogueG2(PlayerG1Dialogue);
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
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);
        BuddyName.SetActive(true);

        DisplayDialogueG3(BuddyG2Dialogue);
    }

    IEnumerator MoveThroughDialogueG3(DialogueAsset dialogue) //G3
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerName.SetActive(true);
        Player.SetActive(true);
        BuddyName.SetActive(false);
        Buddy.SetActive(false);

        DisplayDialogueG4(PlayerG2Dialogue);
    }

    IEnumerator MoveThroughDialogueG4(DialogueAsset dialogue) //G4
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerName.SetActive(false);
        Player.SetActive(false);
        Buddy.SetActive(true);
        Time.timeScale = 1.0f;
        DialoguePanel.SetActive(false);

        BuddyName.SetActive(false);
        Info.SetActive(false);

        Items.SetActive(true);
        DialogueScript.SetActive(false);
        Sheriff.SetActive(true);

        Cursor.visible = false;
    }

    public void DisplayDialogueG1(DialogueAsset dialogue) //G1
    {
        StartCoroutine(MoveThroughDialogueG1(dialogue));
    }

    public void DisplayDialogueG2(DialogueAsset dialogue) //G2
    {
        StartCoroutine(MoveThroughDialogueG2(dialogue));
    }

    public void DisplayDialogueG3(DialogueAsset dialogue) //G3
    {
        StartCoroutine(MoveThroughDialogueG3(dialogue));
    }

    public void DisplayDialogueG4(DialogueAsset dialogue) //G4
    {
        StartCoroutine(MoveThroughDialogueG4(dialogue));
    }
}
