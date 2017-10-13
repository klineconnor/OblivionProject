using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour {

	public static EquipmentManager Instance;

	void Awake() 
	{
		Instance = this;
	}

	public Equipment[] currentEquipment;
	public Weapon currentWeapon;
	public GameObject equipmentUI;
	public EquipmentSlot[] equipSlots;
	public GameObject equipmentObject;
	public EquipObject[] equipObjects;
	public WeaponSlot weaponSlot;
	public WeaponObject weaponObject;

	void Start() 
	{
		currentEquipment = new Equipment[6];
		equipObjects = equipmentObject.GetComponentsInChildren<EquipObject> ();
		equipSlots = equipmentUI.GetComponentsInChildren<EquipmentSlot> ();
	}

	public void SetEquipment(Equipment equip) 
	{
		int NewEquipType = (int)equip.equipType;
		currentEquipment[NewEquipType] = equip;
		equipSlots [NewEquipType].SetEquip (equip);
	}

	public void RemoveEquipment(int equipSlot)
	{
		Inventory.Instance.AddItem (currentEquipment[equipSlot]);
		currentEquipment[equipSlot] = null;
		equipSlots [equipSlot].RemoveEquip ();
	}

	public Equipment GetEquipment(EquipType equipType)
	{
		Equipment currentEquip;
		currentEquip = currentEquipment[(int)equipType];
		return currentEquip;
	}

	public Weapon GetWeapon()
	{
		return currentWeapon;
	}

	public void SetWeapon(Weapon weapon)
	{
		currentWeapon = weapon;
		weaponSlot.SetEquip(weapon);
	}

	public void RemoveWeapon()
	{
		Inventory.Instance.AddItem(currentWeapon);
		currentWeapon = null;
		weaponSlot.RemoveEquip();
		if (weaponObject.GetComponentsInChildren<BroadSword>() != null)
		{
			Destroy(weaponObject.GetComponentInChildren<BroadSword>().gameObject);
		}
	}
}
