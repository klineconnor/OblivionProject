using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat {
	[SerializeField]
	private int baseStat;

	private List<int> modifiers = new List<int>();

	public int GetStat() {
		int finalStat = baseStat;
		modifiers.ForEach (x => finalStat += x);
		return finalStat;
	}

	public void AddModifier(int modifier) {
		if (modifier != 0) {
			modifiers.Add (modifier);
		}
	}

	public void RemoveModifier(int modifier) {
		if (modifier != 0) {
			modifiers.Remove (modifier);
		}
	}
}
