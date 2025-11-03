using UnityEngine;

public class NPCStateScript : MonoBehaviour
{
    public GameObject NPCModel;
    public GameObject FoodModel;

    public GameManagerScripts GameManager;

    private void Update()
    {
        if (GameManager.SanityHigh)
        {
            NPCModel.SetActive(true);
            FoodModel.SetActive(false);
        }
        else if (GameManager.SanityLow)
        {
            NPCModel.SetActive(false);
            FoodModel.SetActive(true);
        }
    }
}
