using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Item item;
    public Image icon;
	public Text itemName;

    public void SetItem(Item newItem)
    {
        item = newItem;
		itemName.text = item.name;
        icon.enabled = true;
		icon.sprite = item.icon;
    }

    public void RemoveItem()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }

    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
        }
    }
}
