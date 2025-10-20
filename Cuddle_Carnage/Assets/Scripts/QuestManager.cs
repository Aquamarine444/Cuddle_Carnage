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
        }

        if (BuddyDialogue.BuddyQuestStarted && !QuestScript.BuddyQuestComplete && Player.NPCTrigger && Input.GetKeyDown(KeyCode.F))
        {

        }
    }
}
