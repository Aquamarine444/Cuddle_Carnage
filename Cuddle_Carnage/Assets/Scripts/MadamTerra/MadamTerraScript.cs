using System.Collections;
using TMPro;
using UnityEngine;

public class MadamTerraScript : MonoBehaviour
{
    public DialogueAsset MadamTerra;

    public GameObject Debris;

    public TMP_Text DialogueText;

    public NPCScript Trigger;

    public TMP_Text QuestText;

    public GameObject DialoguePanel;

    private void Update()
    {
        if (Trigger.PlayerNear && Input.GetKeyDown(KeyCode.F))
        {
            DialoguePanel.SetActive(true);
            DisplayDialogue1(MadamTerra);
            Time.timeScale = 0;
        }
    }

    IEnumerator MoveThroughDialogue1(DialogueAsset dialogue) //1
    {
        for (int i = 0; i < dialogue.dialogue.Length; i++)
        {
            DialogueText.text = dialogue.dialogue[i].Dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.RightArrow));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        Time.timeScale = 1.0f;
        
        QuestText.text = "Head to the Aviary";

        DialoguePanel.SetActive(false);
        Debris.SetActive(false);

        Cursor.visible = false;

    }

    public void DisplayDialogue1(DialogueAsset dialogue) //1
    {
        StartCoroutine(MoveThroughDialogue1(dialogue));
    }
}
