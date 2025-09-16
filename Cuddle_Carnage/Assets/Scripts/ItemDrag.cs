using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Transform OGParent;
    CanvasGroup canvasGroup;
    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
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
}
