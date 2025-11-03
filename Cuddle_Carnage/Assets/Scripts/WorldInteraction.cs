using System.Globalization;
using TMPro;
using UnityEngine;

public class WorldInteraction : MonoBehaviour
{
    public bool PlayerNear;
    public GameObject Panel;
    public GameObject Info;
    public TMP_Text InfoText;

    public bool Interactable;
    public bool Trigger;
    public bool Player;

    private void Update()
    {
        if (PlayerNear && Interactable)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Time.timeScale = 0f;
                Panel.SetActive(true);
                Cursor.visible = true;
                Info.SetActive(false);
            }
        }

        if (Player)
        {
            Time.timeScale = 0f;
            Panel.SetActive(true);
            Cursor.visible = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Interactable)
            {
                PlayerNear = true;
                Info.SetActive(true);
                InfoText.text = "F to Read";
            }

            if (Trigger)
            {
                Player = true;
            }

        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Interactable)
            {
                PlayerNear = false;
                Info.SetActive(false);
            }

            if (Trigger)
            {
                Player = false;
            }
        }
    }

    public void ClosePanel()
    {
        Time.timeScale = 1.0f;
        Player = false;
        Panel.SetActive(false);
        Cursor.visible = false; 

        if (Interactable && PlayerNear)
        {
            Info.SetActive(true);
        }
    }
}
