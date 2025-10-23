using System.Collections.Generic;
using System.IO;
using Unity.Cinemachine;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    private string SaveLocation;
    private InventoryController inventoryController;
    private HotbarController hotbarController;

    private void Start()
    {
        //Define save location
        SaveLocation = Path.Combine(Application.persistentDataPath, "saveData.json");
        inventoryController = FindObjectOfType<InventoryController>();
        hotbarController = FindObjectOfType<HotbarController>();

        LoadGame();
    }

    public void SaveGame()
    {
        SaveData saveData = new SaveData();
        {
            saveData.PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
            saveData.mapboundary = FindObjectOfType<CinemachineConfiner2D>().BoundingShape2D.name;
            saveData.inventorySaveData = inventoryController.GetInventoryItems();
            //saveData.hotbarSaveData = hotbarController.GetHotbarItems();

            saveData.handinQuestIDs = QuestController4.Instance.handinQuestIDs;
        }

        File.WriteAllText(SaveLocation, JsonUtility.ToJson(saveData));
    }

    public void LoadGame()
    {
        if (File.Exists(SaveLocation))
        {
            SaveData saveData = JsonUtility.FromJson<SaveData>(File.ReadAllText(SaveLocation));

            GameObject.FindGameObjectWithTag("Player").transform.position = saveData.PlayerPosition;

            FindObjectOfType<CinemachineConfiner2D>().BoundingShape2D = 
            GameObject.Find(saveData.mapboundary).GetComponent<PolygonCollider2D>();

            inventoryController.SetInventoryItems(saveData.inventorySaveData);
            //hotbarController.SetHotbarItems(saveData.hotbarSaveData);

            QuestController4.Instance.handinQuestIDs = saveData.handinQuestIDs;

        }
        else
        {
            SaveGame();

            inventoryController.SetInventoryItems(new List<InventorySaveData>());
            hotbarController.SetHotbarItems(new List<InventorySaveData>()); 
        }
    }
}
