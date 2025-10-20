using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class QuestUI : MonoBehaviour
{
    public Transform questListContent;
    public GameObject QuestEntryPrefab;
    public GameObject ObjectiveTextPrefab;

    public Quest TestQuest;
    public int TestQuestAmount;
    private List<QuestProgress> testQuestProgressList = new();

    private void Start()
    {
        for (int i = 0; i < TestQuestAmount; i++)
        {
            testQuestProgressList.Add(new QuestProgress(TestQuest));
        }

        UpdateQuestUI();
    }

    public void UpdateQuestUI()
    {
        //Destroy existing quest entries
        foreach (Transform child in questListContent)
        {
            Destroy(child.gameObject);
        }

        //Build quest entries
        foreach (var quest in testQuestProgressList)
        {
            GameObject entry = Instantiate(QuestEntryPrefab, questListContent);
            TMP_Text questNameText = entry.transform.Find("txt_QuestName").GetComponent<TMP_Text>();

            Transform objectiveList = entry.transform.Find("pnl_ObjectiveList");
            questNameText.text = quest.quest.name;

            foreach (var objective in quest.QuestList)
            {
                GameObject objTextGO = Instantiate(ObjectiveTextPrefab, objectiveList);
                TMP_Text objText = objTextGO.GetComponent<TMP_Text>();
                objText.text = $"{objective.Description} ({objective.CurrentAmount}/{objective.RequiredAmount})";
            }
        }
    }
}
