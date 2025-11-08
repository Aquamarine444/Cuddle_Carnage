using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public bool PlayerNear = false;
    public string ObjectName;
    public GameObject Item;

    public bool Collectable;
    public bool Edible;

    public GameObject EKeyInfo;
    public GameObject FKeyInfo;

    public TMP_Text InfoFText;
    public TMP_Text InfoEText;

    private InventoryController inventoryController;

    public AudioSource Pickup;
    public AudioSource Eat;

    private void Start()
    {
        inventoryController = FindObjectOfType<InventoryController>();
    }

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerNear = true;

            if (Collectable)
            {
                FKeyInfo.SetActive(true);
                InfoFText.text = "F to Pickup";
            }

            if (Edible)
            {
                FKeyInfo.SetActive(true);
                InfoFText.text = "F to Pickup";

                EKeyInfo.SetActive(true);
                InfoEText.text = "E to Eat";
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerNear = false;

            if (Collectable)
            {
                FKeyInfo.SetActive(false);
            }

            if (Edible)
            {
                FKeyInfo.SetActive(false);

                EKeyInfo.SetActive(false);
            }
        }
    }

    public void Eaten()
    {
        Destroy(this.gameObject);
        Eat.Play();

    }

    public void CollectItem()
    {
        if (PlayerNear)
        {
            //Item item = GetComponent<Item>();

            /*if (item != null)
            {
               
            }*/

            //Add item to inventory
            bool itemAdded = inventoryController.AddItem(this.gameObject);

            if (itemAdded)
            {
                {
                    Destroy(this.gameObject);
                    Pickup.Play();
                }
            }
        }
    }
}
