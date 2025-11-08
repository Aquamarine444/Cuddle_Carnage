using System.Collections;
using TMPro;
using UnityEngine;

public class TabbyQuestManager : MonoBehaviour
{
    public GameObject PreQuestItem;
    public GameObject PlayerName;
    public GameObject PlayerImage;
    public GameObject TabbyImage;
    public GameObject DialogueText;
    public GameObject TabbyName;
    public GameObject BabyCImage;
    public GameObject BabyCName;

    public GameObject Info;
    public TMP_Text QuestText;

    public TabbyDialogueManager TabbyDialogue;
    public GameObject DialogueManager;
    public PlayerMovement Player;

    public NPCScript NPC;

    public PlayerMovement Inventory;

    private enum QuestState { NotStarted, InProgress, Completed }
    private QuestState questState = QuestState.NotStarted;

    public Quest quest; //Quest NPC gives

    //General Dialogue
    [Header("Dialogue Asset General: ")]
    public DialogueAsset GeneralDialogue;
    public DialogueAsset SadGeneral;

    //What does NPC say while quest is in progress

    [Header("Dialogue: ")]
    public DialogueAsset MidQuestDialogue1;
    public DialogueAsset MidQuestDialogue2;
    public DialogueAsset MidQuestDialogue3;

    [SerializeField] private TMP_Text DialogueSpeech;
    public GameObject DialoguePanel;

    public GameObject BabyC;

    private void Update()
    {
        if (!TabbyDialogue.QuestStarted && TabbyDialogue.QuestComplete)
        {
            questState = QuestState.Completed;
            TabbyDialogue.QuestComplete = false;
        }

        if (questState == QuestState.Completed && !QuestController4.Instance.isQuestHandedIn(quest.QuestID))
        {
            HandleQuestCompletion(quest);
        }

        string foundItem = null;
        foreach (string item in Inventory.Inventory)
        {
            if (item == "Creepy Doll")
            {
                foundItem = item;
                break;
            }
        }

        if (TabbyDialogue.QuestStarted && !TabbyDialogue.QuestComplete && NPC.PlayerNear && Input.GetKeyDown(KeyCode.F)
            && foundItem != null && questState == QuestState.InProgress && !TabbyDialogue.QuestInProgress)
        {
            Time.timeScale = 0;
            PreQuestItem.SetActive(false);
            TabbyImage.SetActive(true);
            PlayerImage.SetActive(false);
            PlayerName.SetActive(false);
            DialogueText.SetActive(true);
            TabbyName.SetActive(true);
            Info.SetActive(true);

            DisplayDialogueMid1(MidQuestDialogue1);
        }
        else if (TabbyDialogue.QuestStarted && !TabbyDialogue.QuestComplete && NPC.PlayerNear && Input.GetKeyDown(KeyCode.F)
            && foundItem == null && questState == QuestState.InProgress && !TabbyDialogue.QuestInProgress)
        {
            Time.timeScale = 0;
            PreQuestItem.SetActive(false);
            TabbyImage.SetActive(true);
            PlayerImage.SetActive(false);
            PlayerName.SetActive(false);
            DialogueText.SetActive(true);
            TabbyName.SetActive(true);
            Info.SetActive(true);

            DisplayDialogueMid1(MidQuestDialogue1);
        }

        if (!TabbyDialogue.QuestStarted && Input.GetKeyDown(KeyCode.F) && NPC.PlayerNear && foundItem == null &&
            !TabbyDialogue.QuestComplete && TabbyDialogue.QuestInProgress)
        {
            Time.timeScale = 0;
            PreQuestItem.SetActive(false);
            BabyCImage.SetActive(true);
            PlayerImage.SetActive(false);
            PlayerName.SetActive(false);
            DialogueText.SetActive(true);
            BabyCName.SetActive(true);
            TabbyImage.SetActive(false);
            TabbyName.SetActive(false);
            Info.SetActive(true);

            DialoguePanel.SetActive(true);


            TabbyDialogue.QuestComplete = true;
            TabbyDialogue.QuestInProgress = false;

            TabbyDialogue.DisplayDialogue21(TabbyDialogue.BabyC21);
        }
    }
    public void StartQuest()
    {
        Time.timeScale = 0;
        PreQuestItem.SetActive(false);
        TabbyImage.SetActive(true);
        PlayerImage.SetActive(false);
        PlayerName.SetActive(false);
        DialogueText.SetActive(true);
        TabbyName.SetActive(true);
        Info.SetActive(true);

        DialoguePanel.SetActive(true);

        TabbyDialogue.DisplayDialogue1(TabbyDialogue.Tabby1);

        QuestController4.Instance.AcceptQuest(quest);
        questState = QuestState.InProgress;
    }

    public void TalkToTabby()
    {
        Time.timeScale = 0;
        PreQuestItem.SetActive(false);
        TabbyImage.SetActive(true);
        PlayerImage.SetActive(false);
        PlayerName.SetActive(false);
        DialogueText.SetActive(true);
        TabbyName.SetActive(true);
        Info.SetActive(true);

        DialoguePanel.SetActive(true);

        if (BabyC.activeInHierarchy)
        {
            DisplayDialogueG1(GeneralDialogue);
        }
        else
        {
            DisplayDialogueG2(SadGeneral);
        }

    }

    void HandleQuestCompletion(Quest quest)
    {
        QuestController4.Instance.HandInQuest(quest.QuestID);
    }


    ////////////////////////////GeneralDialogue//////////////////////////

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
        Time.timeScale = 1.0f;
        PreQuestItem.SetActive(true);
        TabbyImage.SetActive(true);
        PlayerImage.SetActive(false);
        PlayerName.SetActive(false);
        DialogueText.SetActive(false);
        TabbyName.SetActive(false);
        Info.SetActive(false);
        DialoguePanel.SetActive(false);
        Cursor.visible = false;
    }

    public void DisplayDialogueG1(DialogueAsset dialogue) //G1
    {
        StartCoroutine(MoveThroughDialogueG1(dialogue));
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
        Time.timeScale = 1.0f;
        PreQuestItem.SetActive(true);
        TabbyImage.SetActive(true);
        PlayerImage.SetActive(false);
        PlayerName.SetActive(false);
        DialogueText.SetActive(false);
        TabbyName.SetActive(false);
        Info.SetActive(false);
        DialoguePanel.SetActive(false);
        Cursor.visible = false;
    }

    public void DisplayDialogueG2(DialogueAsset dialogue) //G2
    {
        StartCoroutine(MoveThroughDialogueG2(dialogue));
    }

    //////////////////////////////Mid Quest Dialogue////////////////////////

    IEnumerator MoveThroughDialogueMid1(DialogueAsset dialogue) //Mid
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        TabbyName.SetActive(false);
        TabbyImage.SetActive(false);
        BabyCImage.SetActive(true);
        BabyCName.SetActive(true);

        DisplayDialogueMid2(MidQuestDialogue2);
    }

    IEnumerator MoveThroughDialogueMid2(DialogueAsset dialogue) //Mid2
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueSpeech.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        TabbyName.SetActive(true);
        TabbyImage.SetActive(true);
        BabyCImage.SetActive(false);
        BabyCName.SetActive(false);

        DisplayDialogueMid3(MidQuestDialogue3);
    }

    IEnumerator MoveThroughDialogueMid3(DialogueAsset dialogue) //Mid3
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
        TabbyImage.SetActive(true);
        BabyCImage.SetActive(false);
        BabyCName.SetActive(false);
        DialogueText.SetActive(false);
        TabbyName.SetActive(false);
        Info.SetActive(false);
        DialoguePanel.SetActive(false);
        Cursor.visible = false;

        QuestText.text = "Return the Creepy doll to the Abandoned Treehouse";
    }

    public void DisplayDialogueMid1(DialogueAsset dialogue) //Mid1
    {
        StartCoroutine(MoveThroughDialogueMid1(dialogue));
    }

    public void DisplayDialogueMid2(DialogueAsset dialogue) //Mid2
    {
        StartCoroutine(MoveThroughDialogueMid2(dialogue));
    }

    public void DisplayDialogueMid3(DialogueAsset dialogue) //Mid3
    {
        StartCoroutine(MoveThroughDialogueMid3(dialogue));
    }
}
