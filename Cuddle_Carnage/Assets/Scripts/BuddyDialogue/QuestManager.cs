using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public GameObject PreQuestItem;
    public GameObject PlayerName;
    public GameObject PlayerImage;
    public GameObject BuddyImage;
    public GameObject DialogueText;
    public GameObject BuddyText;
    public GameObject Info;

    public DialogueManager BuddyDialogue;
    public GameObject DialogueManager;
    public LakeSideScript QuestScript;
    public PlayerMovement Player;

    private enum QuestState { NotStarted, InProgress, Completed }
    private QuestState questState = QuestState.NotStarted;

    public Quest quest; //Quest NPC gives

    //What does NPC say while quest is in progress

    [Header("Dialogue: ")]
    public DialogueAsset MidQuestDialogue;

    [SerializeField] private TMP_Text DialogueSpeech;
    public GameObject DialoguePanel;

    public void StartBuddyQuest()
    {
        Time.timeScale = 0;
        PreQuestItem.SetActive(false);
        BuddyImage.SetActive(false);
        PlayerImage.SetActive(true);
        PlayerName.SetActive(true);
        DialogueText.SetActive(true);
        BuddyText.SetActive(true);
        Info.SetActive(true);

        BuddyDialogue.DisplayDialogue1(BuddyDialogue.Player1Dialogue);

        QuestController4.Instance.AcceptQuest(quest);
        questState = QuestState.InProgress;
        
    }

    public void TalkToBuddy()
    {
        Time.timeScale = 0;
        PreQuestItem.SetActive(false);
        BuddyImage.SetActive(true);
        PlayerImage.SetActive(false);
        PlayerName.SetActive(false);
        DialogueText.SetActive(true);
        BuddyText.SetActive(true);
        Info.SetActive(true);

        BuddyDialogue.DisplayDialogueG1(BuddyDialogue.BuddyG1Dialogue);
    }

    private void Update()
    {
        if (QuestScript.BuddyQuestComplete && Player.NPCTrigger && Input.GetKeyDown(KeyCode.F))
        {
            Time.timeScale = 0;
            PreQuestItem.SetActive(false);
            BuddyImage.SetActive(true);
            PlayerImage.SetActive(false);
            PlayerName.SetActive(false);
            DialogueText.SetActive(true);
            BuddyText.SetActive(true);
            Info.SetActive(true);

            QuestScript.BuddyQuestComplete = false;

            BuddyDialogue.DisplayDialogue21(BuddyDialogue.Buddy21Dialogue);
            questState = QuestState.Completed;

        }

        if (questState == QuestState.Completed && !QuestController4.Instance.isQuestHandedIn(quest.QuestID))
        {
            HandleQuestCompletion(quest);
        }

        if (BuddyDialogue.BuddyQuestStarted && !QuestScript.BuddyQuestComplete && Player.NPCTrigger && Input.GetKeyDown(KeyCode.F))
        {
            Time.timeScale = 0f;
            BuddyText.SetActive(true);
            PreQuestItem.SetActive(false);
            BuddyImage.SetActive(true);
            DialogueText.SetActive(true);
            Info.SetActive(true);
            DisplayDialogueMid(MidQuestDialogue);
        }
    }

    IEnumerator MoveThroughDialogueMid(DialogueAsset dialogue) 
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        BuddyImage.SetActive(false);
        PlayerName.SetActive(false);
        DialoguePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void DisplayDialogueMid(DialogueAsset dialogue) //Mid Quest
    {
        StartCoroutine(MoveThroughDialogueMid(dialogue));
    }

    void HandleQuestCompletion(Quest quest)
    {
        QuestController4.Instance.HandInQuest(quest.QuestID);
    }
}
