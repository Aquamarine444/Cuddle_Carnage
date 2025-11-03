using System.Collections;
using TMPro;
using UnityEngine;

public class SheriffQuestManager : MonoBehaviour
{
    public GameObject PreQuestItem;
    public GameObject PlayerName;
    public GameObject PlayerImage;
    public GameObject SheriffImage;
    public GameObject DialogueText;
    public GameObject SheriffName;
    public GameObject Info;

    public SheriffDialogueManager SheriffDialogue;
    public GameObject DialogueManager;
    public NPCScript TriggerCheck;

    public SheriffQuestEnd QuestEnd;

    private enum QuestState { NotStarted, InProgress, Completed }
    private QuestState questState = QuestState.NotStarted;

    public Quest quest; //Quest NPC gives

    //What does NPC say while quest is in progress

    [Header("Dialogue: ")]
    public DialogueAsset MidQuestDialogue;

    public DialogueAsset Sheriff1;
    public DialogueAsset Player1;
    public DialogueAsset Sheriff2;

    public DialogueAsset SheriffPanic;

    [SerializeField] private TMP_Text DialogueSpeech;
    public GameObject DialoguePanel;

    public GameManagerScripts GameManager;

    private void Update()
    {
        if (!SheriffDialogue.QuestStarted && QuestEnd.QuestComplete)
        {
            questState = QuestState.Completed;
            QuestEnd.QuestComplete = false;
        }

        if (questState == QuestState.Completed && !QuestController4.Instance.isQuestHandedIn(quest.QuestID))
        {
            HandleQuestCompletion(quest);
        }

        if (SheriffDialogue.QuestStarted && !QuestEnd.QuestComplete && TriggerCheck.PlayerNear && Input.GetKeyDown(KeyCode.F))
        {
            Time.timeScale = 0;
            DialoguePanel.SetActive(true);
            PreQuestItem.SetActive(false);
            SheriffImage.SetActive(true);
            DialogueText.SetActive(true);
            SheriffName.SetActive(true);
            Info.SetActive(true);
            DisplayDialogueMid(MidQuestDialogue);
        }
    }

    public void StartQuest()
    {
        Time.timeScale = 0;
        PreQuestItem.SetActive(false);
        SheriffImage.SetActive(true);
        PlayerImage.SetActive(false);
        PlayerName.SetActive(false);
        DialogueText.SetActive(true);
        SheriffName.SetActive(true);
        Info.SetActive(true);

        SheriffDialogue.DisplayDialogue1(SheriffDialogue.Sheriff1);

        QuestController4.Instance.AcceptQuest(quest);
        questState = QuestState.InProgress;
    }

    public void TalkToSheriff()
    {
        Time.timeScale = 0;
        PreQuestItem.SetActive(false);
        SheriffImage.SetActive(true);
        PlayerImage.SetActive(false);
        PlayerName.SetActive(false);
        DialogueText.SetActive(true);
        SheriffName.SetActive(true);
        Info.SetActive(true);

        if (GameManager.BadCounter == 0)
        {
            DisplayDialogueG1(Sheriff1);
        }
        else
        {
            DisplayDialogueP1(SheriffPanic);
        }

    }

    void HandleQuestCompletion(Quest quest)
    {
        QuestController4.Instance.HandInQuest(quest.QuestID);
    }

    ////////////////////////////MidQuestDialogue/////////////////////
  
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
        PlayerName.SetActive(false);
        PlayerImage.SetActive(false);
        SheriffImage.SetActive(true);
        Time.timeScale = 1.0f;
        DialoguePanel.SetActive(false);

        SheriffName.SetActive(false);
        Info.SetActive(false);

        PreQuestItem.SetActive(true);
        DialogueText.SetActive(false);

        Cursor.visible = false;
    }

    public void DisplayDialogueMid(DialogueAsset dialogue) //Mid
    {
        StartCoroutine(MoveThroughDialogueMid(dialogue));
    }

    ////////////////////////General Dialogue//////////////////////////

    IEnumerator MoveThroughDialogueG1(DialogueAsset dialogue) //G1
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerName.SetActive(true);
        PlayerImage.SetActive(true);
        SheriffImage.SetActive(false);
        SheriffName.SetActive(false);

        DisplayDialogueG2(Player1);
    }

    IEnumerator MoveThroughDialogueG2(DialogueAsset dialogue) //G2
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerName.SetActive(false);
        PlayerImage.SetActive(false);
        SheriffImage.SetActive(true);
        SheriffName.SetActive(true);

        DisplayDialogueG3(Sheriff2);
  
    }

    IEnumerator MoveThroughDialogueG3(DialogueAsset dialogue) //G3
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerName.SetActive(false);
        PlayerImage.SetActive(false);
        SheriffImage.SetActive(true);
        Time.timeScale = 1.0f;
        DialoguePanel.SetActive(false);

        SheriffName.SetActive(false);
        Info.SetActive(false);

        PreQuestItem.SetActive(true);
        DialogueText.SetActive(false);

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

    ////////////////////////////Bad General Dialogue///////////////////////

    IEnumerator MoveThroughDialogueP1(DialogueAsset dialogue) //P1
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        PlayerName.SetActive(false);
        PlayerImage.SetActive(false);
        SheriffImage.SetActive(true);
        Time.timeScale = 1.0f;
        DialoguePanel.SetActive(false);

        SheriffName.SetActive(false);
        Info.SetActive(false);

        PreQuestItem.SetActive(true);
        DialogueText.SetActive(false);

        Cursor.visible = false;
    }

    public void DisplayDialogueP1(DialogueAsset dialogue) //P1
    {
        StartCoroutine(MoveThroughDialogueP1(dialogue));
    }
}
