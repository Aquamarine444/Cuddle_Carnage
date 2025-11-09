using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    Transform OGParent;
    CanvasGroup canvasGroup;

    [Header("Consumed")]
    public PlayerMovement PlayerManagement;
    private CollectibleScript Collectible;
    public GameObject EdibleInfo;
    public GameObject CollectableInfo;
    public TMP_Text CollectibleInfoText;
    public string Info;

    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        Collectible =GetComponent<CollectibleScript>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        OGParent = transform.parent; //save original parent
        transform.SetParent(transform.root);
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0.6f; //semi-transparent during drag action

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position; //follow the mouse pointer
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;

        Slotnventory DropSlot = eventData.pointerEnter?.GetComponent<Slotnventory>();

        if (DropSlot == null)
        {
            GameObject Item = eventData.pointerEnter;
            if (Item != null )
            {
                DropSlot = Item.GetComponentInParent<Slotnventory>();
            }
        }
        Slotnventory OGSlot = OGParent.GetComponent<Slotnventory>();

        if (DropSlot != null)
        {
            if (DropSlot.currentItem != null)
            {
                //Swaps slot items
                DropSlot.currentItem.transform.SetParent(OGSlot.transform);
                OGSlot.currentItem = DropSlot.currentItem;
                DropSlot.currentItem.GetComponent<RectTransform>().anchoredPosition = new Vector2(-50,-50);
            }
            else
            {
                OGSlot.currentItem = null;
            }

            //Move item into slot
            transform.SetParent(DropSlot.transform);
            DropSlot.currentItem = gameObject;
        }
        else
        {
            //no slot when releasing item
            transform.SetParent(OGParent);
        }

        GetComponent<RectTransform>().anchoredPosition = new Vector2(-50,-50); //centres object Was Vector2.zero
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (Collectible.Edible)
            {
                string foundItem = null;
                foreach (string item in PlayerManagement.Inventory)
                {
                    if (item == Collectible.ObjectName)
                    {
                        foundItem = item;
                        break;
                    }
                }

                if (PlayerManagement.HealthSanityBar.fillAmount != 1.0f)
                {
                    if (foundItem != null)
                    {
                        PlayerManagement.Inventory.Remove(foundItem);
                    }

                    Collectible.Eaten();
                    PlayerManagement.HealthSanityBar.fillAmount += 0.5f;
                    PlayerManagement.Timer = 40f;
                }

                PlayerManagement.Inventory.Remove(foundItem);
                EdibleInfo.SetActive(false);

            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (Collectible.Edible)
        {
            EdibleInfo.SetActive(true);
            CollectibleInfoText.text = Info;
            CollectableInfo.SetActive(true);
        }
        else if (Collectible.Collectable)
        {
            CollectibleInfoText.text = Info;
            CollectableInfo.SetActive(true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (Collectible.Edible)
        {
            EdibleInfo.SetActive(false);
            CollectableInfo.SetActive(false);
        }
        else if (Collectible.Collectable)
        {
            CollectableInfo.SetActive(false);
        }
    }

}
