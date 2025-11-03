using UnityEngine;
using TMPro;

public class NPCFoodScript : MonoBehaviour
{
    public bool PlayerNear;
    public GameObject Info;
    public TMP_Text InfoText;
    public GameObject Fluff;
    public GameObject NPC;

    public GameManagerScripts GameManager;
    public TMP_Text QuestText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerNear = true;
            Info.SetActive(true);
            InfoText.text = "E to Eat";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerNear = false;
            Info.SetActive(false);
        }
    }

    public void Eaten()
    {
        Fluff.SetActive(true);
        NPC.SetActive(false);
        GameManager.BadCounter += 1;
    }
}
