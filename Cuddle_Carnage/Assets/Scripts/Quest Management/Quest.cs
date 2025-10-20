using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quest/ QuestAsset")]
public class Quest : ScriptableObject
{
    public string QuestID;
    public string QuestName;
    public string QuestDescription;
    public List<QuestObjective> QuestList;

    private void OnValidate()
    {
        if (string.IsNullOrEmpty(QuestID))
        {
            QuestID = QuestName + Guid.NewGuid().ToString();
        }
    }
}

[System.Serializable]
public class QuestObjective
{
    public string ObjectiveID;
    public string Description;
    public ObjectiveType type;
    public int RequiredAmount;
    public int CurrentAmount;

    public bool IsCompleted => CurrentAmount >= RequiredAmount;
}

public enum ObjectiveType { CollectItem, DefeatEnemy, ReachLocation, TalkNPC, Custom }

[System.Serializable]

public class QuestProgress
{
    public Quest quest;
    public List<QuestObjective> QuestList;

    public QuestProgress(Quest quest)
    {
        this.quest = quest;
        QuestList = new List<QuestObjective>();

        //Deep copy

        foreach (var obj in quest.QuestList)
        {
            QuestList.Add(new QuestObjective
            {
                ObjectiveID = obj.ObjectiveID,
                Description = obj.Description,
                type = obj.type,
                RequiredAmount = obj.RequiredAmount,
                CurrentAmount = 0
            });
        }
    }

    public bool IsCompleted => QuestList.TrueForAll(o => o.IsCompleted);

    public string QuestID => quest.QuestID;
}


