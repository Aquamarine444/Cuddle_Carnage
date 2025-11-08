using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SystemScreensManagement : MonoBehaviour
{
    public string SceneName;
    public GameObject InventoryPanel;

    public GameObject loadingPanel;
    public Image progressBar;

    public bool ButtonClicked;

    public GameObject Button;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneName);
        Time.timeScale = 1.0f;
        Cursor.visible = true;
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
            Cursor.visible = true;
        }
    }

    public void CloseInventory()
    {
        InventoryPanel.SetActive(false);
        Time.timeScale = 1.0f;
        Cursor.visible = false;
    }

    public void LoadScene(string sceneName)
    {
        loadingPanel.SetActive(true);
        progressBar.fillAmount = 0f;
        StartCoroutine(LoadAsync(sceneName));
    }

    IEnumerator LoadAsync(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            progressBar.fillAmount = progress;

            if (operation.progress >= 0.9f && !operation.allowSceneActivation)
            {
                Button.SetActive(true);
                if (ButtonClicked)
                {
                    operation.allowSceneActivation = true;
                }
            }

            yield return null;
        }

        loadingPanel.SetActive(false);
    }

    public void ContinueGame()
    {
        ButtonClicked = true;
    }

    public void FinishTutorail()
    {
        Cursor.visible = false;
        Time.timeScale = 1.0f;
    }
}
