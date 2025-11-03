using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FluffScript : MonoBehaviour
{
    private int RandomCount;
    public bool PlayerNear;

    public GameObject Info;
    public TMP_Text InfoText;

    public GameObject DialoguePanel;
    public TMP_Text DialogueText;



    [Header("Dialogue Assets")]
    public DialogueAsset Reaction1;
    public DialogueAsset Reaction2;
    public DialogueAsset Reaction3;
    public DialogueAsset Reaction4;

    private void Update()
    {
        if (PlayerNear && Input.GetKeyDown(KeyCode.F))
        {
            RandomCount = Random.Range(1, 5);

        }

        if (RandomCount == 1)
        {
            DialoguePanel.SetActive(true);

            Cursor.visible = true;

            DisplayDialogue1(Reaction1);

            RandomCount = 0;
        }
        else if (RandomCount == 2)
        {
            DialoguePanel.SetActive(true);

            Cursor.visible = true;

            DisplayDialogue1(Reaction2);

            RandomCount = 0;
        }
        else if (RandomCount == 3)
        {
            DialoguePanel.SetActive(true);

            Cursor.visible = true;
            DisplayDialogue1(Reaction3);

            RandomCount = 0;
        }
        else if (RandomCount == 4)
        {
            DialoguePanel.SetActive(true);

            Cursor.visible = true;

            DisplayDialogue1(Reaction4);

            RandomCount = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerNear = true;
            Info.SetActive(true);
            InfoText.text = "F to Investigate?";
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

    //////////////////////Dialogue///////////////////

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
        Cursor.visible = false;

        DialoguePanel.SetActive(false);
    }

    public void DisplayDialogue1(DialogueAsset dialogue) //1
    {
        StartCoroutine(MoveThroughDialogue1(dialogue));
    }
}
