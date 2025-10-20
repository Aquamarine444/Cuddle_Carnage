using UnityEngine;
using UnityEngine.SceneManagement;

public class SystemScreensManagement : MonoBehaviour
{
    public string SceneName;
    public GameObject InventoryPanel;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneName);
        Time.timeScale = 1.0f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            InventoryPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void CloseInventory()
    {
        InventoryPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
