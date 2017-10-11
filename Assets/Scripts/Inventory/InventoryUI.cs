using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour {

    Inventory inventory;
    public Transform itemsParent;
    InventorySlot[] slots;
	GameObject tempSlot;
    public GameObject inventorySlot;
    
    void Start()
    {
        inventory = Inventory.Instance;
        inventory.onItemChangedCallback += UpdateUI;    // Subscribe to the onItemChanged callback

        // Populate our slots array
        
    }

    private void Update()
    {
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
		for (int i = 0; i < inventory.items.Count; i++) {
			slots [i].SetItem(inventory.items [i]);
		}
    }

    void UpdateUI()
    {
        if (slots.Length < inventory.items.Count)
        {
			Debug.Log (inventory.items.Count);
            Instantiate(inventorySlot, itemsParent);
        } else {
			Destroy(slots[inventory.items.Count].gameObject);
        }
    }
}
