using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Inventory/Weapon")]
public class Weapon : Item {
	public WeaponType weaponType;
	public int BaseAttack;
	public GameObject EquipObject;
	GameObject EquipClone;

	public int StrengthModifier;
	public int EnduranceModifier;
	public int PerceptionModifier;
	public int IntelligenceModifier;
	public int WisdomModifier;
	public int DexterityModifier;
	public int CharismaModifier;
	public int LuckModifier;

	public override void Use ()
	{
		base.Use();
		EquipmentManager.Instance.SetWeapon (this);
		EquipClone = Instantiate (EquipObject, EquipmentManager.Instance.weaponObject.transform);
		RemoveItem ();
		PlayerStats.Instance.Strength.AddModifier (StrengthModifier);
		PlayerStats.Instance.Endurance.AddModifier (EnduranceModifier);
		PlayerStats.Instance.Perception.AddModifier (PerceptionModifier);
		PlayerStats.Instance.Intelligence.AddModifier (IntelligenceModifier);
		PlayerStats.Instance.Wisdom.AddModifier (WisdomModifier);
		PlayerStats.Instance.Dexterity.AddModifier (DexterityModifier);
		PlayerStats.Instance.Charisma.AddModifier (CharismaModifier);
		PlayerStats.Instance.Luck.AddModifier (LuckModifier);
	}
}
	
public enum WeaponType {BroadSword, Claymore, Bow, Mace, BattleAxe, WarHammer, WarAxe, Staff};