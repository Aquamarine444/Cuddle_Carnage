using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public bool PlayerNear;
    public GameObject DialoguePanel;

    private void Update()
    {
        if (PlayerNear)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                DialoguePanel.SetActive(true);
            }
        }    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerNear = false;
        }
    }
}
