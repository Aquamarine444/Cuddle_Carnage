using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BCEndScript : MonoBehaviour
{
    public bool PlayerNear;
    public BCDialogueManager DialogueManager;

    [Header("Characters: ")]
    public GameObject BaronOnyx;
    public GameObject Player;
    public GameObject BabyC;

    public GameObject Pheobe;

    [Header("Items: ")]
    public TMP_Text DialogueText;
    public GameObject DialoguePanel;
    public GameObject BabyCarniAvatar;
    public GameObject BaronOnyxAvatar;
    public GameObject PiggyBackC;
    public TMP_Text QuestText;

    public GameManagerScripts GameManager;

    public Button QuestButton;
    public bool QuestComplete;

    public AudioSource QuestCompleteSFX;

    [Header("Dialogue Assets: ")]
    public DialogueAsset BaronOnyx1Dialogue; //1
    public DialogueAsset Player1Dialogue; //2
    public DialogueAsset BaronOnyx2Dialogue; //3
    public DialogueAsset Player2Dialogue; //4
    public DialogueAsset BaronOnyx3Dialogue; //5
    public DialogueAsset BabyCarni1Dialogue; //6
    public DialogueAsset Player3Dialogue; //7
    public DialogueAsset BaronOnyx4Dialogue; //8
    public DialogueAsset Player4Dialogue; //9
    public DialogueAsset BaronOnyx5Dialogue; //10
    public DialogueAsset Player5Dialogue; //11
    public DialogueAsset BaronOnyx6Dialogue; //12
    public DialogueAsset Player6Dialogue; //13
    public DialogueAsset BaronOnyx7Dialogue; //14
    public DialogueAsset Player7Dialogue; //15
    public DialogueAsset BaronOnyx8Dialogue; //16

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (DialogueManager.QuestStarted)
            {
                Time.timeScale = 0f;
                DialoguePanel.SetActive(true);
                BaronOnyx.SetActive(true);
                DisplayDialogue1(BaronOnyx1Dialogue);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerNear = false;
        }
    }

    IEnumerator MoveThroughDialogue1(DialogueAsset dialogue) //1
    {
        DialogueManager.QuestStarted = false;
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        BaronOnyx.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue2(Player1Dialogue);
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
        BaronOnyx.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue3(BaronOnyx2Dialogue);
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
        BaronOnyx.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue4(Player2Dialogue);
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
        BaronOnyx.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue5(BaronOnyx3Dialogue);
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
        BaronOnyx.SetActive(false);
        BabyC.SetActive(true);

        DisplayDialogue6(BabyCarni1Dialogue);
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
        BabyC.SetActive(false);
        Player.SetActive(true);
        PiggyBackC.SetActive(false);

        DisplayDialogue7(Player3Dialogue);
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
        BaronOnyx.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue8(BaronOnyx4Dialogue);
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
        BaronOnyx.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue9(Player4Dialogue);
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
        BaronOnyx.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue10(BaronOnyx5Dialogue);
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
        BaronOnyx.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue11(Player5Dialogue);
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
        BaronOnyx.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue12(BaronOnyx6Dialogue);
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
        BaronOnyx.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue13(Player6Dialogue);
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
        BaronOnyx.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue14(BaronOnyx7Dialogue);
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
        BaronOnyx.SetActive(false);
        Player.SetActive(true);

        DisplayDialogue15(Player7Dialogue);
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
        BaronOnyx.SetActive(true);
        Player.SetActive(false);

        DisplayDialogue16(BaronOnyx8Dialogue);
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
        BaronOnyx.SetActive(false);
        Player.SetActive(false);
        DialoguePanel.SetActive(false);
        BaronOnyxAvatar.SetActive(false);   
        GameManager.BabyCQuest = true;
        GameManager.QuestCounter += 1;
        QuestText.text = "No Active Quest";
        Time.timeScale = 1.0f;

        QuestButton.interactable = false;
        QuestComplete = true;
        Pheobe.SetActive(true);
        QuestCompleteSFX.Play();

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
}
