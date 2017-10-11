using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject {

    new public string name = "item";
    public float weight;
    public Sprite icon;

    public virtual void Use()
    {
        Debug.Log("Use " + name);
    }

	public void RemoveItem() {
		Inventory.Instance.RemoveItem (this);
	}
}
