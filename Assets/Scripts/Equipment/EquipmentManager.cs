using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour {

	public static EquipmentManager Instance;

	void Awake() {
		Instance = this;
	}

	public Equipment[] CurrentEquipment;
	public GameObject EquipmentArea;
	public EquipmentSlot[] EquipSlots;
	public GameObject EquipmentObject;
	public EquipObject[] EquipObjects;

	void Start() {
		CurrentEquipment = new Equipment[7];
		EquipObjects = EquipmentObject.GetComponentsInChildren<EquipObject> ();
		EquipSlots = EquipmentArea.GetComponentsInChildren<EquipmentSlot> ();
	}

	public void SetEquipment(Equipment equip) {
		int NewEquipType = (int)equip.equipType;
		CurrentEquipment[NewEquipType] = equip;
		EquipSlots [NewEquipType].SetEquip (equip);
	}

	public void RemoveEquipment(int equipSlot) {
		Inventory.Instance.AddItem (CurrentEquipment[equipSlot]);
		CurrentEquipment[equipSlot] = null;
		EquipSlots [equipSlot].RemoveEquip ();
	}
}
