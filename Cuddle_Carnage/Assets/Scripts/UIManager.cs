using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject NPCPanel;
    public void ClosePanels()
    {
        Time.timeScale = 1.0f;
        NPCPanel.SetActive(false);
    }
}
