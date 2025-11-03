using System.Collections;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;

public class PheobeQuestManager : MonoBehaviour
{
    public GameObject PreQuestItem;
    public GameObject PlayerName;
    public GameObject PlayerImage;
    public GameObject PheobeImage;
    public GameObject DialogueText;
    public GameObject PheobeName;
    public GameObject Info;
    public TMP_Text QuestText;

    public PheobeDialogueManager PheobeDialogue;
    public GameObject DialogueManager;
    public PlayerMovement Player;

    public NPCScript NPC;

    public InventoryController InventoryControl;
    private enum QuestState { NotStarted, InProgress, Completed }
    private QuestState questState = QuestState.NotStarted;

    public Quest quest; //Quest NPC gives

    //General Dialogue
    [Header("Dialogue Asset General: ")]
    public DialogueAsset GeneralDialogue;

    //What does NPC say while quest is in progress

    [Header("Dialogue: ")]
    public DialogueAsset MidQuestDialogue;

    [SerializeField] private TMP_Text DialogueSpeech;
    public GameObject DialoguePanel;

    public PlayerMovement Inventory;

    private void Update()
    {
        if (!PheobeDialogue.QuestStarted && PheobeDialogue.QuestComplete)
        {
            questState = QuestState.Completed;
            PheobeDialogue.QuestComplete = false;
        }

        if (questState == QuestState.Completed && !QuestController4.Instance.isQuestHandedIn(quest.QuestID))
        {
            HandleQuestCompletion(quest);
        }

                string foundItem = null;
        foreach (string item in Inventory.Inventory)
        {
            if (item == "Pheobe's Bone")
            {
                foundItem = item;
                break;
            }
        }

        if (PheobeDialogue.QuestStarted && !PheobeDialogue.QuestComplete && Input.GetKeyDown(KeyCode.F) && NPC.PlayerNear
            && foundItem == null)
        {
            Time.timeScale = 0;
            PreQuestItem.SetActive(false);
            PheobeImage.SetActive(true);
            PlayerImage.SetActive(false);
            PlayerName.SetActive(false);
            DialogueText.SetActive(true);
            PheobeName.SetActive(true);
            Info.SetActive(true);

            DisplayDialogueMid(MidQuestDialogue);
        }



        if (PheobeDialogue.QuestStarted && foundItem != null)
        {
            QuestText.text = "Return Phemur to Pheobe";
        }

        if (PheobeDialogue.QuestStarted && foundItem != null && Input.GetKeyDown(KeyCode.F) && NPC.PlayerNear)
        {
            Time.timeScale = 0;
            PreQuestItem.SetActive(false);
            PheobeImage.SetActive(true);
            PlayerImage.SetActive(false);
            PlayerName.SetActive(false);
            DialogueText.SetActive(true);
            PheobeName.SetActive(true);
            Info.SetActive(true);

            DialoguePanel.SetActive(true);

            Inventory.Inventory.Remove(foundItem);
            //Destroy(Phemur);

            PheobeDialogue.QuestStarted = false;

            PheobeDialogue.DisplayDialogue021(PheobeDialogue.Pheobe21);

            InventoryControl.RemoveItemsFromInventory(5);
        }
    }

    public void StartQuest()
    {
        Time.timeScale = 0;
        PreQuestItem.SetActive(false);
        PheobeImage.SetActive(true);
        PlayerImage.SetActive(false);
        PlayerName.SetActive(false);
        DialogueText.SetActive(true);
        PheobeName.SetActive(true);
        Info.SetActive(true);

        DialoguePanel.SetActive(true);

        PheobeDialogue.DisplayDialogue1(PheobeDialogue.Pheobe1);

        QuestController4.Instance.AcceptQuest(quest);
        questState = QuestState.InProgress;
    }

    public void TalkToPheobe()
    {
        Time.timeScale = 0;
        PreQuestItem.SetActive(false);
        PheobeImage.SetActive(true);
        PlayerImage.SetActive(false);
        PlayerName.SetActive(false);
        DialogueText.SetActive(true);
        PheobeName.SetActive(true);
        Info.SetActive(true);

        DialoguePanel.SetActive(true);

        DisplayDialogueG1(GeneralDialogue);
    }

    void HandleQuestCompletion(Quest quest)
    {
        QuestController4.Instance.HandInQuest(quest.QuestID);
    }

    /////////////////////General Dialogue////////////////////

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
        PheobeImage.SetActive(true);
        PlayerImage.SetActive(false);
        PlayerName.SetActive(false);
        DialogueText.SetActive(false);
        PheobeName.SetActive(false);
        Info.SetActive(false);
        DialoguePanel.SetActive(false);
        Cursor.visible = false;
    }

    public void DisplayDialogueG1(DialogueAsset dialogue) //G1
    {
        StartCoroutine(MoveThroughDialogueG1(dialogue));
    }

    ///////////////////////MidQuest Dialogue////////////////////

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
        PheobeImage.SetActive(true);
        PlayerImage.SetActive(false);
        PlayerName.SetActive(false);
        DialogueText.SetActive(false);
        PheobeName.SetActive(false);
        Info.SetActive(false);
        DialoguePanel.SetActive(false);
        Cursor.visible = false;
    }

    public void DisplayDialogueMid(DialogueAsset dialogue) //Mid
    {
        StartCoroutine(MoveThroughDialogueMid(dialogue));
    }
}
