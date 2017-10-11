using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Inventory/Weapon")]
public class Weapon : Equipment {
	public WeaponType weaponType;
	public int BaseAttack;

	public override void Use ()
	{
		base.Use ();
		if (EquipClone.GetComponent<BroadSword> () != null) {
			EquipClone.GetComponent<BroadSword> ().SetAttack (BaseAttack);
		}
	}
}
	
public enum WeaponType {BroadSword, Claymore, Bow, Mace, BattleAxe, WarHammer, WarAxe, Staff};