using System.Collections.Generic;
using UnityEngine;

public class QuestController4 : MonoBehaviour
{
    public static QuestController4 Instance { get; private set; }

    public List<QuestProgress> activateQuests = new();
    private QuestUI questUI;

    public List<string> handinQuestIDs = new();

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        questUI = FindObjectOfType<QuestUI>();
    }

    public void AcceptQuest (Quest quest)
    {
        if (IsQuestActive(quest.QuestID)) return;

        activateQuests.Add(new QuestProgress(quest));

        questUI.UpdateQuestUI();
    }

    public bool IsQuestActive(string questID) => activateQuests.Exists(q => q.QuestID == questID);

    public bool IsQuestCompleted(string questID)
    {
        QuestProgress quest = activateQuests.Find(q => q.QuestID == questID);
        return quest != null && quest.QuestList.TrueForAll(o => o.IsCompleted);
    }

    public void HandInQuest (string questID)
    {
        //remove required items
        //if (!RemoveRequiredItemsFromInventory(questID))
        //{return; } -quest could not be completed - missing items


        //remove quest from quest log
        QuestProgress quest = activateQuests.Find(q => q.QuestID == questID);
        if (quest != null)
        {
            handinQuestIDs.Add(questID);
            activateQuests.Remove(quest);
            questUI.UpdateQuestUI();
        }
    }

    public bool isQuestHandedIn(string questID)
    {
        return handinQuestIDs.Contains(questID);
    }

    /*public bool RemoveRequiredItemsFromInventory(string questID)
    {
        QuestProgress quest = activateQuests.Find(q => q.QuestID == questID);
        if (quest == null) return false;

        Dictionary<int, int> requiredItems = new();

        //Item requirements from objective
        foreach(QuestObjective objective in quest.QuestList)
        {
            if(objective.type == ObjectiveType.CollectItem && int.TryParse(objective.ObjectiveID, out int itemID))
            {
                requiredItems[itemID] = objective.RequiredAmount;
            }
        }

        //Verify
        Dictionary<int, int> itemCounts = InventoryController.Instance.GetItemCounts();
        foreach(var item in requiredItems)
        {
            if(itemCounts.GetValueOrDefault(item.Key) < item.Value)
            {
                // not enough items to complete quest
                return false;
            }
        }

        //Remove required items form inventory
        foreach(var itemRequirement in requiredItems)
        {
            //remove items from inventory
            //InventoryController.Instance.RemoveItemsFromInventory(itemRequirement.Key, itemRequirement.Value);
        }

        return true;
    }*/
}
