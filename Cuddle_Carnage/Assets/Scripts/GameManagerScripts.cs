using TMPro;
using UnityEngine;

public class GameManagerScripts : MonoBehaviour
{
    [Header("Quest System:")]
    public bool BuddyQuest; //1
    public bool PandoraQuest; //2
    public bool TabbyQuest; //3
    public bool BabyCQuest; //4
    public bool PheobeQuest; //5

    public int QuestCounter;

    public bool AllQuestComplete;

    public GameObject Debris;
    public TMP_Text QuestHint;

    public TMP_Text QuestText;
    //Add sound

    [Header("Sanity System: ")]
    public bool SanityLow;
    public bool SanityHigh;

    [Header("Bad Check System")]
    public int BadCounter = 0;

    [Header("NPC Check:")]
    public GameObject Buddy;
    public GameObject Pandora;
    public GameObject Tabby;
    public GameObject BabyC;
    public GameObject Pheobe;

    private void Update()
    {
        QuestText.text = QuestCounter.ToString() + "/5";
        if (BuddyQuest && PandoraQuest && TabbyQuest && BabyCQuest && PheobeQuest)
        {
            AllQuestComplete = true;
        }

        if (AllQuestComplete)
        {
            Debris.SetActive(false);
            QuestHint.text = "Head to the Aviary";
        }

        if (!Buddy.activeInHierarchy && !Pandora.activeInHierarchy && !Tabby.activeInHierarchy && !BabyC.activeInHierarchy 
            && !Pheobe.activeInHierarchy)
        {
            Debris.SetActive(false);
            QuestHint.text = "Head to the Aviary";
        }
    }

}
