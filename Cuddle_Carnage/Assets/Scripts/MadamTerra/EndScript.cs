using TMPro;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public GameManagerScripts GameManager;

    public GameObject EndScreen;

    public TMP_Text Conclusion;
    public TMP_Text GoodCounterText;
    public TMP_Text BadCounterText;

    public TMP_Text InfoText;

    public GameObject GeneralSound;
    public GameObject EndSound;

    private void Update()
    {
        /*if (GameManager.BadCounter != 0 && GameManager.QuestCounter != 0)
        {
            if (GameManager.BadCounter - GameManager.QuestCounter == 1 || GameManager.QuestCounter - GameManager.BadCounter == 1)
            {
                Conclusion.text = "Neutral Ending";
                InfoText.text = "Ending 3 of 3";
            }
        } 
        else*/ if (GameManager.BadCounter == GameManager.QuestCounter)
        {
            Conclusion.text = "Neutral Ending";
            InfoText.text = "Ending 3 of 3";
        }
        else if (GameManager.BadCounter > GameManager.QuestCounter)
        {
            Conclusion.text = "Bad Ending";
            InfoText.text = "Ending 2 of 3";
        }
        else if (GameManager.QuestCounter > GameManager.BadCounter)
        {
            Conclusion.text = "Good Ending";
            InfoText.text = "Ending 1 of 3";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0;
            EndScreen.SetActive(true);
            BadCounterText.text = "Bad Points: " + GameManager.BadCounter.ToString();
            GoodCounterText.text = "Good Points: " + GameManager.QuestCounter.ToString();

            GeneralSound.SetActive(false);
            EndSound.SetActive(true);
            Cursor.visible = true;
        }
    }
}
