using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	public static PlayerStats Instance;

	void Awake() {
		Instance = this;
	}

	public int baseHealth;
	int currentHealth;
	int maxHealth;
	public int baseMagic;
	int currentMagic;
	int maxMagic;
	public int baseStamina;
	int currentStamina;
	int maxStamina;

	public Stat Strength;
	public Stat Intelligence;
	public Stat Dexterity;
	public Stat Endurance;
	public Stat Charisma;
	public Stat Wisdom;
	public Stat Luck;

	public Skill OneHand;
	public Skill TwoHand;

	void Start() {
		SetMaxHealth ();
		SetMaxMagic ();
		SetMaxStamina ();

		currentHealth = maxHealth;
		currentMagic = maxMagic;
		currentStamina = maxStamina;
	}

	public int GetCurrentHealth() {
		return currentHealth;
	}

	public int GetMaxHealth() {
		SetMaxHealth ();
		return maxHealth;
	}

	public void SetMaxHealth() {
		maxHealth = baseHealth;
		maxHealth += (Strength.GetStat () * 2);
		maxHealth += Endurance.GetStat ();
	}

	public int GetCurrentMagic() {
		return currentMagic;
	}

	public int GetMaxMagic() {
		SetMaxMagic ();
		return maxMagic;
	}

	public void SetMaxMagic() {
		maxMagic = baseMagic;
		maxMagic += Intelligence.GetStat ();
	}

	public int GetCurrentStamina() {
		return currentStamina;
	}

	public int GetMaxStamina() {
		SetMaxStamina ();
		return maxStamina;
	}

	public void SetMaxStamina() {
		maxStamina = baseStamina;
		maxStamina += Endurance.GetStat ();
	}
}
