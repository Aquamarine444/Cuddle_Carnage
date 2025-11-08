using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PheobeDialogueManager : MonoBehaviour
{
    public bool QuestStarted;
    public bool QuestComplete;

    [Header("Text: ")]
    [SerializeField] private TMP_Text DialogueText;
    [SerializeField] private TMP_Text QuestText;

    public GameObject Info;

    [Header("Characters: ")]
    public GameObject PheobeName;
    public GameObject Pheobe;
    public GameObject Player;
    public GameObject PlayerName;

    public GameObject Tabby;
    public GameObject BabyC;
    public GameObject BabyCFluff;
    public SpriteRenderer BabyCSprite;

    [Header("Dialogue Asset: ")]
    public DialogueAsset Pheobe1; //1
    public DialogueAsset Player1; //2
    public DialogueAsset Pheobe2; //3
    public DialogueAsset Player2; //4
    public DialogueAsset Pheobe3; //5
    public DialogueAsset Player3; //6
    public DialogueAsset Pheobe4; //7
    public DialogueAsset Player4; //8
    public DialogueAsset Pheobe5; //9
    public DialogueAsset Player5; //10
    public DialogueAsset Pheobe6; //11
    public DialogueAsset Player6; //12
    public DialogueAsset Pheobe7; //13
    public DialogueAsset Player7; //14
    public DialogueAsset Pheobe8; //15
    public DialogueAsset Player8; //16
    public DialogueAsset Pheobe9; //17
    public DialogueAsset Player9; //18
    public DialogueAsset Pheobe10; //19
    public DialogueAsset Player10; //20
    public DialogueAsset Pheobe11; //21
    public DialogueAsset Player11; //22
    public DialogueAsset Pheobe12; //23
    public DialogueAsset Player12; //24
    public DialogueAsset Pheobe13; //25
    public DialogueAsset Player13; //26

    [Header("End Dialogue Asset: ")]
    public DialogueAsset Pheobe21; //2.1
    public DialogueAsset Player21; //2.2
    public DialogueAsset Pheobe22; //2.3
    public DialogueAsset Player22; //2.4
    public DialogueAsset Pheobe23; //2.5
    public DialogueAsset Player23; //2.6
    public DialogueAsset Pheobe24; //2.7
    public DialogueAsset Player24; //2.8
    public DialogueAsset Pheobe25; //2.9
    public DialogueAsset Player25; //2.10
    public DialogueAsset Pheobe26; //2.11
    public DialogueAsset Player26; //2.12
    public DialogueAsset Pheobe27; //2.13


    [Header("Extras: ")]
    public GameManagerScripts GameManager;
    public GameObject DialoguePanel;
    public GameObject Dialogue;
    public GameObject Items;
    public Button QuestButton;

    public GameObject Food;
    public AudioSource QuestCompleteSFX;


    /////////////////////////Start Quest/////////////////////

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
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue2(Player1);
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
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue3(Pheobe2);
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
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue4(Player2);
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
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue5(Pheobe3);
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
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue6(Player3);
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
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue7(Pheobe4);
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
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue8(Player4);
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
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue9(Pheobe5);
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
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue10(Player5);
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
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue11(Pheobe6);
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
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue12(Player6);
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
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue13(Pheobe7);
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
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue14(Player7);
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
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue15(Pheobe8);
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
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue16(Player8);
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
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue17(Pheobe9);
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
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue18(Player9);
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
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue19(Pheobe10);
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
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue20(Player10);
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
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue21(Pheobe11);
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
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue22(Player11);
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
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue23(Pheobe12);
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
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue24(Player12);
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
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue25(Pheobe13);
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
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue26(Player13);
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
        Time.timeScale = 1.0f;
        PheobeName.SetActive(false);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);
        QuestText.text = "Find Phemur in the Graveyard and Return it to Pheobe";

        DialoguePanel.SetActive(false);
        QuestStarted = true;
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

    ///////////////////////End Quest////////////////////////

    IEnumerator MoveThroughDialogue021(DialogueAsset dialogue) //2.1
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue022(Player21);
    }

    IEnumerator MoveThroughDialogue022(DialogueAsset dialogue) //2.2
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue023(Pheobe22);
    }

    IEnumerator MoveThroughDialogue023(DialogueAsset dialogue) //2.3
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue024(Player22);
    }

    IEnumerator MoveThroughDialogue024(DialogueAsset dialogue) //2.4
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue025(Pheobe23);
    }

    IEnumerator MoveThroughDialogue025(DialogueAsset dialogue) //025
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue026(Player23);
    }

    IEnumerator MoveThroughDialogue026(DialogueAsset dialogue) //026
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue027(Pheobe24);
    }

    IEnumerator MoveThroughDialogue027(DialogueAsset dialogue) //027
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue028(Player24);
    }

    IEnumerator MoveThroughDialogue028(DialogueAsset dialogue) //028
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue029(Pheobe25);
    }

    IEnumerator MoveThroughDialogue029(DialogueAsset dialogue) //029
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue0210(Player25);
    }

    IEnumerator MoveThroughDialogue0210(DialogueAsset dialogue) //0210
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue0211(Pheobe26);
    }

    IEnumerator MoveThroughDialogue0211(DialogueAsset dialogue) //0211
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PheobeName.SetActive(false);
        Pheobe.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

        DisplayDialogue0212(Player26);
    }

    IEnumerator MoveThroughDialogue0212(DialogueAsset dialogue) //0212
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PheobeName.SetActive(true);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue0213(Pheobe27);
    }

    IEnumerator MoveThroughDialogue0213(DialogueAsset dialogue) //0213
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PheobeName.SetActive(false);
        Pheobe.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DialoguePanel.SetActive(false);
        Info.SetActive(false);
        Items.SetActive(true);

        QuestButton.interactable = false;
        Dialogue.SetActive(false);

        QuestComplete = true;

        GameManager.PheobeQuest = true;
        GameManager.QuestCounter += 1;

        QuestText.text = "No active quest";
        Time.timeScale = 1.0f;

        Food.SetActive(true);

        Tabby.SetActive(true);
        BabyC.transform.position = new Vector2(112.77f, -11.78f);
        BabyCFluff.transform.position = new Vector2(112.77f, -11.78f);
        BabyCSprite.flipX = false;

        Cursor.visible = false;

        QuestCompleteSFX.Play();

    }

    public void DisplayDialogue021(DialogueAsset dialogue) //021
    {
        StartCoroutine(MoveThroughDialogue021(dialogue));
    }

    public void DisplayDialogue022(DialogueAsset dialogue) //022
    {
        StartCoroutine(MoveThroughDialogue022(dialogue));
    }

    public void DisplayDialogue023(DialogueAsset dialogue) //023
    {
        StartCoroutine(MoveThroughDialogue023(dialogue));
    }

    public void DisplayDialogue024(DialogueAsset dialogue) //024
    {
        StartCoroutine(MoveThroughDialogue024(dialogue));
    }

    public void DisplayDialogue025(DialogueAsset dialogue) //025
    {
        StartCoroutine(MoveThroughDialogue025(dialogue));
    }

    public void DisplayDialogue026(DialogueAsset dialogue) //026
    {
        StartCoroutine(MoveThroughDialogue026(dialogue));
    }

    public void DisplayDialogue027(DialogueAsset dialogue) //027
    {
        StartCoroutine(MoveThroughDialogue027(dialogue));
    }

    public void DisplayDialogue028(DialogueAsset dialogue) //028
    {
        StartCoroutine(MoveThroughDialogue028(dialogue));
    }

    public void DisplayDialogue029(DialogueAsset dialogue) //029
    {
        StartCoroutine(MoveThroughDialogue029(dialogue));
    }

    public void DisplayDialogue0210(DialogueAsset dialogue) //0210
    {
        StartCoroutine(MoveThroughDialogue0210(dialogue));
    }

    public void DisplayDialogue0211(DialogueAsset dialogue) //0211
    {
        StartCoroutine(MoveThroughDialogue0211(dialogue));
    }

    public void DisplayDialogue0212(DialogueAsset dialogue) //0212
    {
        StartCoroutine(MoveThroughDialogue0212(dialogue));
    }

    public void DisplayDialogue0213(DialogueAsset dialogue) //0213
    {
        StartCoroutine(MoveThroughDialogue0213(dialogue));
    }
}
