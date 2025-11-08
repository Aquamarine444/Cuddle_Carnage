using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SheriffDialogueManager : MonoBehaviour
{
    [Header("Text: ")]
    [SerializeField] private TMP_Text DialogueText;
    [SerializeField] private TMP_Text QuestText;

    public GameObject Items;
    public GameObject Info;

    public GameObject SheriffName;

    [Header("Characters: ")]
    public GameObject Sheriff;
    public GameObject Player;
    public GameObject PlayerName;
    public GameObject DialoguePanel;


    [Header("Dialogue Lines: ")]
    public DialogueAsset Sheriff1; //1
    public DialogueAsset Player1; //2
    public DialogueAsset Sheriff2; //3
    public DialogueAsset Player2; //4
    public DialogueAsset Sheriff3; //5
    public DialogueAsset Player3; //6
    public DialogueAsset Sheriff4; //7
    public DialogueAsset Player4; //8
    public DialogueAsset Sheriff5; //9
    public DialogueAsset Player5; //10
    public DialogueAsset Sheriff6; //11
    public DialogueAsset Player6; //12
    public DialogueAsset Sheriff7; //13
    public DialogueAsset Player7; //14
    public DialogueAsset Sheriff8; //15
    public DialogueAsset Player8; //16
    public DialogueAsset Sheriff9; //17
    public DialogueAsset Player9; //18
    public DialogueAsset Sheriff10; //19
    public DialogueAsset Player10; //20

    [Header("Extra: ")]
    public bool QuestStarted;
    public GameObject DialogueScript;
    public GameManagerScripts GameManager;

    public GameObject SheriffAvatar;
    public GameObject SheriffFluff;
    public GameObject Pandora;
    public GameObject KiteTree;
    public GameObject NormalTree;

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
        PlayerName.SetActive(true);
        Player.SetActive(true);
        Sheriff.SetActive(false);

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
        Player.SetActive(false);
        Sheriff.SetActive(true);

        DisplayDialogue3(Sheriff2);
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

        Player.SetActive(true);
        Sheriff.SetActive(false);

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
        Player.SetActive(false);
        Sheriff.SetActive(true);

        DisplayDialogue5(Sheriff3);
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

        Player.SetActive(true);
        Sheriff.SetActive(false);

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
        Player.SetActive(false);
        Sheriff.SetActive(true);

        DisplayDialogue7(Sheriff4);
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

        Player.SetActive(true);
        Sheriff.SetActive(false);

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
        Player.SetActive(false);
        Sheriff.SetActive(true);

        DisplayDialogue9(Sheriff5);
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

        Player.SetActive(true);
        Sheriff.SetActive(false);

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
        Player.SetActive(false);
        Sheriff.SetActive(true);

        DisplayDialogue11(Sheriff6);
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

        Player.SetActive(true);
        Sheriff.SetActive(false);

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
        Player.SetActive(false);
        Sheriff.SetActive(true);

        DisplayDialogue13(Sheriff7);
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

        Player.SetActive(true);
        Sheriff.SetActive(false);

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
        Player.SetActive(false);
        Sheriff.SetActive(true);

        DisplayDialogue15(Sheriff8);
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

        Player.SetActive(true);
        Sheriff.SetActive(false);

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
        Player.SetActive(false);
        Sheriff.SetActive(true);

        DisplayDialogue17(Sheriff9);
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

        Player.SetActive(true);
        Sheriff.SetActive(false);

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
        Player.SetActive(false);
        Sheriff.SetActive(true);

        DisplayDialogue19(Sheriff10);
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

        Player.SetActive(true);
        Sheriff.SetActive(false);

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
        Player.SetActive(false);
        PlayerName.SetActive(false);
        Time.timeScale = 1.0f;
        DialoguePanel.SetActive(false);
        QuestText.text = "Find Pandora in the Forest";
        QuestStarted = true;
        Cursor.visible = false;

        Pandora.SetActive(true);
        KiteTree.SetActive(true);
        NormalTree.SetActive(false);
        DialogueScript.SetActive(false);

        Info.SetActive(false);
        Items.SetActive(true);
        
        SheriffName.SetActive(false);

        Sheriff.SetActive(true);

        SheriffAvatar.transform.position = new Vector2(-3.58f, -41.14f);
        SheriffFluff.transform.position = new Vector2(-3.58f, -41.14f);
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
}
