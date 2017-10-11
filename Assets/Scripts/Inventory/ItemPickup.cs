using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : interactible {

    public Item item;
    Inventory inventory;

    void Start()
    {
        inventory = Inventory.Instance;
    }

    public override void Interact()
    {
		base.Interact ();
        if (inventory.CheckWeight(item))
        {
			Debug.Log ("Add item");
            inventory.AddItem(item);
            Destroy(gameObject);
        }
    }
}
