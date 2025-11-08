using System.Collections;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class LakeSideScript : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public TMP_Text DialogueText;
    public GameObject Player;
    public GameObject PlayerName;
    public GameObject DialoguePanel;
    public bool BuddyQuestComplete;
    public TMP_Text QuestText;

    public DialogueAsset PlayerRant;

    public AudioSource QuestCompleteSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (dialogueManager.BuddyQuestStarted)
            {
                Player.SetActive(true);
                PlayerName.SetActive(true);
                DialoguePanel.SetActive(true);
                DisplayDialogue1(PlayerRant);
                Time.timeScale = 0f;
            }
        }
    }

    IEnumerator MoveThroughDialogue1(DialogueAsset dialogue) //1
    {
        dialogueManager.BuddyQuestStarted = false;
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        Player.SetActive(false);
        PlayerName.SetActive(false);

        DialoguePanel.SetActive(false);
        QuestText.text = "Return to Buddy";
        Time.timeScale = 1.0f;
        BuddyQuestComplete = true;
        QuestCompleteSFX.Play();

        this.gameObject.SetActive(false);

    }

    public void DisplayDialogue1(DialogueAsset dialogue) //1
    {
        StartCoroutine(MoveThroughDialogue1(dialogue));
    }
}
