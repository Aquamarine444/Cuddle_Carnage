using TMPro;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public bool PlayerNear;
    public GameObject DialoguePanel;

    public GameObject Food;
    public GameObject Fluff;

    //public QuestManager dialogueData;

    public GameObject Info;
    public TMP_Text InfoText;


    private void Update()
    {
        if (PlayerNear)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                DialoguePanel.SetActive(true);
                Time.timeScale = 0.0f;
                Cursor.visible = true;
                Info.SetActive(false);
            }
        }    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerNear = true;
            Info.SetActive(true);
            InfoText.text = "F to talk";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerNear = false;
            Info.SetActive(false);
        }
    }

   /* private void SyncQuestState()
    {
        if (dialogueData.quest == null) return;

        string questID = dialogueData.quest.QuestID;
        
        if (QuestController4.Instance.IsQuestCompleted(questID) || QuestController4.Instance.IsQuestHandedIn(questID))
        {
            questState = QuestState.Completed;
        }
        else if (QuestController4.Instance.IsQuestActive(questID))
        {
            questState = QuestState.InProgress;
        }
        else
        {
            questState = QuestState.NotStarted;
        }
    }*/
}
