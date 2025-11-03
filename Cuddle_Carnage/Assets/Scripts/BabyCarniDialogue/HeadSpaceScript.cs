using TMPro;
using UnityEngine;

public class HeadSpaceScript : MonoBehaviour
{
    public GameObject BabyC;
    public BCQuestManager QuestManager;

    public GameObject Info;
    public TMP_Text InfoText;

    private void Update()
    {
        if (BabyC.activeInHierarchy)
        {
            Info.SetActive(true);
            InfoText.text = "Q to talk to Baby Carni";
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Time.timeScale = 0;
                QuestManager.DialoguePanel.SetActive(true);
                QuestManager.PreQuestItem.SetActive(false);
                QuestManager.BabyCImage.SetActive(true);
                QuestManager.DialogueText.SetActive(true);
                QuestManager.BabyCName.SetActive(true);
                QuestManager.Info.SetActive(true);
                QuestManager.DisplayDialogueMid(QuestManager.MidQuestDialogue);
            }
        }
        else
        {
            Info.SetActive(false);
        }
    }
}
