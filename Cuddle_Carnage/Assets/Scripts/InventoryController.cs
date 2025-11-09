using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    private ItemDictionary itemDictionary;

    public GameObject inventoryPanel;
    public GameObject slotPrefab;
    public int slotCount;
    public GameObject[] itemPrefabs;

    private void Start()
    {
        itemDictionary = FindObjectOfType<ItemDictionary>();

        //SetInventoryItems(GetInventoryItems());
    }

    public bool AddItem(GameObject itemPrefab)
    {
        //look for empty slot
        foreach (Transform slotTransform in inventoryPanel.transform)
        {
            Slotnventory slot = slotTransform.GetComponent<Slotnventory>();
            if (slot != null && slot.currentItem == null)
            {
                GameObject newItem = Instantiate(itemPrefab, slotTransform);
                slot.currentItem = newItem;
                newItem.GetComponent<RectTransform>().anchoredPosition = new Vector2(-50, -50);
                return true;
            }
        }

        Debug.Log("Inventory is full");
        return false;

    }

    public List<InventorySaveData> GetInventoryItems()
    {
        List<InventorySaveData> invData = new List<InventorySaveData>();
        foreach (Transform slotTransform in inventoryPanel.transform)
        {
            Slotnventory slot = slotTransform.GetComponent<Slotnventory>();
            if (slot.currentItem != null)
            {
                Item item = slot.currentItem.GetComponent<Item>();
                invData.Add(new InventorySaveData { itemID = item.ID, slotIndex = slotTransform.GetSiblingIndex() });
            }
        }
        return invData;
    }

    public void SetInventoryItems(List<InventorySaveData> inventorySaveData)
    {
        //Clear inventory panel - avoid duplicates
       /* foreach (Transform child in inventoryPanel.transform)
        {
            Destroy(child.gameObject);
        } */

        //Create new slots
        for (int i = 0; i < slotCount; i++)
        {
            Instantiate(slotPrefab, inventoryPanel.transform);
        }

        //populate slots with saved items
        foreach (InventorySaveData data in inventorySaveData)
        {
            if (data.slotIndex < slotCount)
            {
                {
                    Slotnventory slot = inventoryPanel.transform.GetChild(data.slotIndex).GetComponent<Slotnventory>();
                    GameObject itemPrefab = itemDictionary.GetItemPrefab(data.itemID);
                    if (itemPrefab != null)
                    {
                        GameObject item = Instantiate(itemPrefab, slot.transform);
                        item.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                        slot.currentItem = item;    
                    }
                }
            }
        }
    }

    public void RemoveItemsFromInventory(int itemID) //int amountToRemove
    {
        foreach(Transform slotTransform in inventoryPanel.transform)
        {
            //if (amountToRemove <= 0) break;

            Slotnventory slot = slotTransform.GetComponent<Slotnventory>();
            /*if (slot?.currentItem?.GetComponent<Item>() is Item item && item.ID == itemID)
            {
                //int removed = Mathf.Min(amountToRemove, item.quantity);
                //amountToRemove -= removed;
                Destroy(slot.currentItem);
                slot.currentItem = null;

                if (Item.quantity == 0)
                {
                    Destroy(slot.currentItem);
                    slot.currentItem = null;
                }
            }*/

            if (slot !=null && slot.currentItem != null)
            {
                Item item = slot.currentItem.GetComponent<Item>();

                if (item != null && item.ID == itemID)
                {
                    Destroy(slot.currentItem);
                    slot.currentItem = null;
                }
            }
        }
    }
}
