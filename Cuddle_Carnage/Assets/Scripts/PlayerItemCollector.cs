using UnityEngine;

public class PlayerItemCollector : MonoBehaviour
{
    private InventoryController inventoryController;
    public bool PickupItem;

    CollectibleScript Collectible;

    private void Start()
    {
        inventoryController = FindObjectOfType<InventoryController>();
    }

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {    
        if (collision.CompareTag("Collectable"))
        {
            Item item = collision.GetComponent<Item>();

            if (item != null)
            {
                //Add item to inventory
                bool itemAdded = inventoryController.AddItem(collision.gameObject);

                if (itemAdded)
                {
                    {
                        Destroy(collision.gameObject);
                    }
                }
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
              
    }
}
