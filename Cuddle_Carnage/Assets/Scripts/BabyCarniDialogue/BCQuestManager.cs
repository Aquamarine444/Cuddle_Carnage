using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BCQuestManager : MonoBehaviour
{
    public GameObject PreQuestItem;
    public GameObject PlayerName;
    public GameObject PlayerImage;
    public GameObject BabyCImage;
    public GameObject DialogueText;
    public GameObject BabyCName;
    public GameObject Info;

    public BCDialogueManager BabyCDialogue;
    public GameObject DialogueManager;
    public PlayerMovement Player;

    public BCEndScript QuestEnd;

    private enum QuestState { NotStarted, InProgress, Completed }
    private QuestState questState = QuestState.NotStarted;

    public Quest quest; //Quest NPC gives

    //What does NPC say while quest is in progress

    [Header("Dialogue: ")]
    public DialogueAsset MidQuestDialogue;

    [SerializeField] private TMP_Text DialogueSpeech;
    public GameObject DialoguePanel;

    [Header("Dialogue Assets: ")]
    public DialogueAsset BabyCarni1;
    public DialogueAsset Player1;
    public DialogueAsset BabyCarni2;
    public DialogueAsset Player2;
    public DialogueAsset BabyCarni3;

    public DialogueAsset Player21;
    public DialogueAsset BabyCarni21;
    public DialogueAsset Player22;

    private void Update()
    {
        if (!BabyCDialogue.QuestStarted && QuestEnd.QuestComplete)
        {
            questState = QuestState.Completed;
            QuestEnd.QuestComplete = false;
        }


        if (questState == QuestState.Completed && !QuestController4.Instance.isQuestHandedIn(quest.QuestID))
        {
            HandleQuestCompletion(quest);
        }

       /* if (BabyCDialogue.QuestStarted && !QuestEnd.QuestComplete && Player.NPCTrigger && Input.GetKeyDown(KeyCode.F))
        {
            Time.timeScale = 0;
            DialoguePanel.SetActive(true);
            PreQuestItem.SetActive(false);
            BabyCImage.SetActive(true);
            DialogueText.SetActive(true);
            BabyCName.SetActive(true);
            Info.SetActive(true);
            DisplayDialogueMid(MidQuestDialogue);
        }*/
    }

    public void StartQuest()
    {
        Time.timeScale = 0;
        PreQuestItem.SetActive(false);
        BabyCImage.SetActive(false);
        PlayerImage.SetActive(true);
        PlayerName.SetActive(true);
        DialogueText.SetActive(true);
        BabyCName.SetActive(false);
        Info.SetActive(true);

        BabyCDialogue.DisplayDialogue1(BabyCDialogue.Player1Dialogue);

        QuestController4.Instance.AcceptQuest(quest);
        questState = QuestState.InProgress;
    }

    public void TalkToBabyC()
    {
        Time.timeScale = 0;
        PreQuestItem.SetActive(false);
        BabyCImage.SetActive(true);
        PlayerImage.SetActive(false);
        PlayerName.SetActive(false);
        DialogueText.SetActive(true);
        BabyCName.SetActive(true);
        Info.SetActive(true);

        if (questState == QuestState.Completed && !QuestEnd.QuestComplete)
        {
            DisplayDialogue21(Player21);
        }
        else
        {
            DisplayDialogue1(BabyCarni1);
        }
    }

    void HandleQuestCompletion(Quest quest)
    {
        QuestController4.Instance.HandInQuest(quest.QuestID);
    }


/////////////////////////////General Dialogue/////////////////////////

    IEnumerator MoveThroughDialogue1(DialogueAsset dialogue) //1
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerImage.SetActive(true);
        PlayerName.SetActive(true);
        BabyCImage.SetActive(false);
        BabyCName.SetActive(false);

        DisplayDialogue2(Player1);
    }

    IEnumerator MoveThroughDialogue2(DialogueAsset dialogue) //2
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
            PlayerImage.SetActive(false);
            PlayerName.SetActive(false);
            BabyCImage.SetActive(true);
            BabyCName.SetActive(true);

            DisplayDialogue3(BabyCarni2);
        

    }

    IEnumerator MoveThroughDialogue3(DialogueAsset dialogue) //3
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerImage.SetActive(true);
        PlayerName.SetActive(true);
        BabyCImage.SetActive(false);
        BabyCName.SetActive(false);

        DisplayDialogue4(Player2);
    }

    IEnumerator MoveThroughDialogue4(DialogueAsset dialogue) //4
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }

            PlayerImage.SetActive(false);
            PlayerName.SetActive(false);
             BabyCImage.SetActive(true);
             BabyCName.SetActive(true);

             DisplayDialogue5(BabyCarni3);

    }

    IEnumerator MoveThroughDialogue5(DialogueAsset dialogue) //5
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
            Time.timeScale = 1.0f;
            PreQuestItem.SetActive(true);
            BabyCImage.SetActive(true);
            PlayerImage.SetActive(false);
            PlayerName.SetActive(false);
            DialogueText.SetActive(false);
            BabyCName.SetActive(false);
            Info.SetActive(false);
            DialoguePanel.SetActive(false);
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

    ///////////////////////General Dialogue 2/////////////////////

    IEnumerator MoveThroughDialogue21(DialogueAsset dialogue) //21
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
            PlayerImage.SetActive(false);
            PlayerName.SetActive(false);
            BabyCImage.SetActive(true);
            BabyCName.SetActive(true);

            DisplayDialogue22(BabyCarni21);
        

    }

    IEnumerator MoveThroughDialogue22(DialogueAsset dialogue) //22
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
            PlayerImage.SetActive(true);
            PlayerName.SetActive(true);
            BabyCImage.SetActive(false);
            BabyCName.SetActive(false);

            DisplayDialogue23(Player22);
        

    }

    IEnumerator MoveThroughDialogue23(DialogueAsset dialogue) //23
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
            Time.timeScale = 1.0f;
            PreQuestItem.SetActive(true);
            BabyCImage.SetActive(true);
            PlayerImage.SetActive(false);
            PlayerName.SetActive(false);
            DialogueText.SetActive(false);
            BabyCName.SetActive(false);
            Info.SetActive(false);
            DialoguePanel.SetActive(false);
            Cursor.visible = false;
        

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

    ///////////////////////////////MidQuestDialogue//////////////////////////////

    IEnumerator MoveThroughDialogueMid(DialogueAsset dialogue) //Mid
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
            Time.timeScale = 1.0f;
            PreQuestItem.SetActive(true);
            BabyCImage.SetActive(true);
            PlayerImage.SetActive(false);
            PlayerName.SetActive(false);
            DialogueText.SetActive(false);
            BabyCName.SetActive(false);
            Info.SetActive(false);
            DialoguePanel.SetActive(false);
            Cursor.visible = false;
        

    }

    public void DisplayDialogueMid(DialogueAsset dialogue) //Mid
    {
        StartCoroutine(MoveThroughDialogueMid(dialogue));
    }
}
