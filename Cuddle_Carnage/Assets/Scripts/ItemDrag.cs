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
                DropSlot.currentItem.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
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

        GetComponent<RectTransform>().anchoredPosition = Vector2.zero; //centres object
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (Collectible.Edible)
            {
                if (PlayerManagement.HealthSanityBar.fillAmount != 1.0f)
                {
                    Collectible.Eaten();
                    PlayerManagement.HealthSanityBar.fillAmount += 0.5f;
                    PlayerManagement.Timer = 15f;
                }

            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (Collectible.Edible)
        {
            EdibleInfo.SetActive(true);
        }
        else
        {
            CollectableInfo.SetActive(true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (Collectible.Edible)
        {
            EdibleInfo.SetActive(false);
        }
        else
        {
            CollectableInfo.SetActive(false);
        }
    }

}
