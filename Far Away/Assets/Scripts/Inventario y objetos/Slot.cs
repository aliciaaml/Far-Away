using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    Item item;

    public Image icon;

    public void AddItem(Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public void CleanSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}
