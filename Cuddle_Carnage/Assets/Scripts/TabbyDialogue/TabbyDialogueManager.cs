using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TabbyDialogueManager : MonoBehaviour
{
    public bool QuestStarted;
    public bool QuestComplete;
    public bool QuestInProgress;

    [Header("Text: ")]
    [SerializeField] private TMP_Text DialogueText;
    [SerializeField] private TMP_Text QuestText;

    public GameObject Info;

    [Header("Characters: ")]
    public GameObject TabbyName;
    public GameObject Tabby;
    public GameObject Player;
    public GameObject PlayerName;
    public GameObject BabyC;
    public GameObject BabyCName;

    [Header("Dialogue Asset: ")]
    public DialogueAsset Tabby1; //1
    public DialogueAsset BabyC1; //2
    public DialogueAsset Tabby2; //3
    public DialogueAsset BabyC2; //4
    public DialogueAsset Tabby3; //5
    public DialogueAsset BabyC3; //6
    public DialogueAsset Tabby4; //7
    public DialogueAsset Player1; //8
    public DialogueAsset BabyC4; //9
    public DialogueAsset Tabby5; //10
    public DialogueAsset Player2; //11
    public DialogueAsset Tabby6; //12
    public DialogueAsset Player3; //13
    public DialogueAsset Tabby7; //14
    public DialogueAsset BabyC5; //15
    public DialogueAsset Tabby8; //16
    public DialogueAsset BabyC6; //17

    [Header("End Dialogue Asset: ")]
    public DialogueAsset BabyC21; //2.1
    public DialogueAsset Tabby21; //2.2
    public DialogueAsset BabyC22; //2.3
    public DialogueAsset Tabby22; //2.4
    public DialogueAsset BabyC23; //2.5
    public DialogueAsset Tabby23; //2.6
    public DialogueAsset Player21; //2.7
    public DialogueAsset Tabby24; //2.8
    public DialogueAsset BabyC24; //2.9
    public DialogueAsset Player22; //2.10
    public DialogueAsset BabyC25; //2.11


    [Header("Extras: ")]
    public GameManagerScripts GameManager;
    public GameObject DialoguePanel;
    public GameObject Dialogue;
    public GameObject Items;
    public Button QuestButton;

    public GameObject Food;
    public GameObject FlowerCrown;
    public GameObject CursedDoll;

    public AudioSource CompleteQuestSFX;

    /////////////////////////Start Quest//////////////////////////////
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(true);
        BabyCName.SetActive(true);

        DisplayDialogue2(BabyC1);
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
        TabbyName.SetActive(true);
        Tabby.SetActive(true);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);

        DisplayDialogue3(Tabby2);
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(true);
        BabyCName.SetActive(true);

        DisplayDialogue4(BabyC2);
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
        TabbyName.SetActive(true);
        Tabby.SetActive(true);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);

        DisplayDialogue5(Tabby3);
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(true);
        BabyCName.SetActive(true);

        DisplayDialogue6(BabyC3);
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
        TabbyName.SetActive(true);
        Tabby.SetActive(true);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);

        DisplayDialogue7(Tabby4);
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue8(Player1);
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(true);
        BabyCName.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue9(BabyC4);
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
        TabbyName.SetActive(true);
        Tabby.SetActive(true);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue10(Tabby5);
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue11(Player2);
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
        TabbyName.SetActive(true);
        Tabby.SetActive(true);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue12(Tabby6);
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue13(Player3);
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
        TabbyName.SetActive(true);
        Tabby.SetActive(true);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue14(Tabby7);
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(true);
        BabyCName.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue15(BabyC5);
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
        TabbyName.SetActive(true);
        Tabby.SetActive(true);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue16(Tabby8);
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(true);
        BabyCName.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue17(BabyC6);
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
        Time.timeScale = 1.0f;
        TabbyName.SetActive(false);
        Tabby.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);
        QuestText.text = "Return the Creepy doll to the Abandoned Treehouse";

        DialoguePanel.SetActive(false);
        QuestStarted = true;

        Cursor.visible = false;

        CursedDoll.SetActive(true);
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


    /////////////////////////End Dialogue/////////////////////////

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
        TabbyName.SetActive(true);
        Tabby.SetActive(true);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);

        DisplayDialogue22(Tabby21);
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(true);
        BabyCName.SetActive(true);

        DisplayDialogue23(BabyC22);
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
        TabbyName.SetActive(true);
        Tabby.SetActive(true);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);

        DisplayDialogue24(Tabby22);
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(true);
        BabyCName.SetActive(true);

        DisplayDialogue25(BabyC23);
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
        TabbyName.SetActive(true);
        Tabby.SetActive(true);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);

        DisplayDialogue26(Tabby23);
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue27(Player21);
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
        TabbyName.SetActive(true);
        Tabby.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue28(Tabby24);
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(true);
        BabyCName.SetActive(true);

        DisplayDialogue29(BabyC24);
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
        TabbyName.SetActive(false);
        Tabby.SetActive(false);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue210(Player22);
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
        BabyC.SetActive(true);
        BabyCName.SetActive(true);

        DisplayDialogue211(BabyC25);
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
        Time.timeScale = 1.0f;
        TabbyName.SetActive(false);
        Tabby.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);
        BabyC.SetActive(false);
        BabyCName.SetActive(false);
        QuestText.text = "No Active Quest";

        DialoguePanel.SetActive(false);

        FlowerCrown.SetActive(true);
        Food.SetActive(true);

        GameManager.TabbyQuest = true;
        GameManager.QuestCounter += 1;

        Cursor.visible = false;

        Info.SetActive(false);
        Dialogue.SetActive(false);
        Items.SetActive(true);

        QuestButton.interactable = false;

        CompleteQuestSFX.Play();
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
}
