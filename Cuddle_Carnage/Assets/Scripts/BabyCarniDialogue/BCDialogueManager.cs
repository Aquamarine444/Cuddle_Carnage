using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BCDialogueManager : MonoBehaviour
{
    [Header("Text: ")]
    [SerializeField] private TMP_Text DialogueText;
    [SerializeField] private TMP_Text QuestText;

    public GameObject Info;

    [Header("Characters: ")]
    public GameObject BabyCName;
    public GameObject BabyC;
    public GameObject Player;
    public GameObject PlayerName;
    public GameObject DialoguePanel;

    public GameObject PiggyBackBabyC;
    public GameObject BabyCarni;
    public GameObject BaronOnyx;
    public GameObject BabyCarniFluff;

    [Header("Extras: ")]
    public GameManagerScripts GameManager;
    public bool QuestStarted;

    public GameObject Debris;

    [Header("Dialogue Assets: ")]
    public DialogueAsset Player1Dialogue; //1
    public DialogueAsset BabyC1Dialogue; //2
    public DialogueAsset Player2Dialogue; //3
    public DialogueAsset BabyC2Dialogue; //4
    public DialogueAsset Player3Dialogue; //5
    public DialogueAsset BabyC3Dialogue; //6
    public DialogueAsset Player4Dialogue; //7
    public DialogueAsset BabyC4Dialogue; //8
    public DialogueAsset Player5Dialogue; //9
    public DialogueAsset BabyC5Dialogue; //10

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
        BabyCName.SetActive(true);
        BabyC.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue2(BabyC1Dialogue);
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
        BabyCName.SetActive(false);
        BabyC.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

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
        BabyCName.SetActive(true);
        BabyC.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue4(BabyC2Dialogue);
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
        BabyCName.SetActive(false);
        BabyC.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

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
        BabyCName.SetActive(true);
        BabyC.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue6(BabyC3Dialogue);
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
        BabyCName.SetActive(false);
        BabyC.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

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
        BabyCName.SetActive(true);
        BabyC.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue8(BabyC4Dialogue);
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
        BabyCName.SetActive(false);
        BabyC.SetActive(false);
        Player.SetActive(true);
        PlayerName.SetActive(true);

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
        BabyCName.SetActive(true);
        BabyC.SetActive(true);
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DisplayDialogue10(BabyC5Dialogue);
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
        PlayerName.SetActive(false);
        Time.timeScale = 1.0f;
        DialoguePanel.SetActive(false);
        PiggyBackBabyC.SetActive(true);

        BaronOnyx.SetActive(true);
        QuestText.text = "Take Baby Carni back to Carnivore Village";
        QuestStarted = true;
        Cursor.visible = false;
        BabyCarni.transform.position = new Vector2(60.7f, 126.5f);
        BabyCarniFluff.transform.position = new Vector2(60.7f, 126.5f);

        Debris.SetActive(false);
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

}
