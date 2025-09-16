using System.IO;
using Unity.Cinemachine;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    private string SaveLocation;

    private void Start()
    {
        //Define save location
        SaveLocation = Path.Combine(Application.persistentDataPath, "saveData.json");

        //LoadGame();
    }

    public void SaveGame()
    {
        SaveData saveData = new SaveData();

        saveData.PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        saveData.mapboundary = FindObjectOfType<CinemachineConfiner2D>().BoundingShape2D.name;

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
        }
    }
}
