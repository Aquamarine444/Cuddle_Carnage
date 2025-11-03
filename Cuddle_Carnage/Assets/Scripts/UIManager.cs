using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject NPCPanel;

    public GameObject MapScreen;
    public GameObject InventoryPanel;

    private void Start()
    {
        //Cursor.visible = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            MapScreen.SetActive(true);
            Cursor.visible = true;
        }
    }
    public void ClosePanels()
    {
        Time.timeScale = 1.0f;
        NPCPanel.SetActive(false);
        Cursor.visible = false;
    }

    public void CloseMap()
    {
        if (!InventoryPanel.activeInHierarchy)
        {
            Cursor.visible = false;
        }
    }
}
