using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : Item {

	public EquipType equipType;
	public GameObject EquipObject;
	public GameObject EquipClone;
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
		base.Use ();
		EquipmentManager.Instance.SetEquipment (this);
		EquipClone = Instantiate (EquipObject, EquipmentManager.Instance.equipObjects[(int)equipType].transform);
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

	public void RemoveModifiers() {
		PlayerStats.Instance.Strength.RemoveModifier (StrengthModifier);
		PlayerStats.Instance.Endurance.RemoveModifier (EnduranceModifier);
		PlayerStats.Instance.Intelligence.RemoveModifier (IntelligenceModifier);
		PlayerStats.Instance.Wisdom.RemoveModifier (WisdomModifier);
		PlayerStats.Instance.Dexterity.RemoveModifier (DexterityModifier);
		PlayerStats.Instance.Charisma.RemoveModifier (CharismaModifier);
		PlayerStats.Instance.Luck.RemoveModifier (LuckModifier);
	}
}

public enum EquipType {Helmet, Chest, Pants, Gloves, OffHand, Boots}; 