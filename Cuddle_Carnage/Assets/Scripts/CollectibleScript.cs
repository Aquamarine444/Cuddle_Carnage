using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public bool PlayerNear = false;
    public string ObjectName;
    public GameObject Item;

    public bool Collectable;
    public bool Edible;

    private InventoryController inventoryController;

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
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerNear = false;
        }
    }

    public void Eaten()
    {
        Destroy(this.gameObject);
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
                }
            }
        }
    }
}
