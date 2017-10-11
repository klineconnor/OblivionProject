using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Skill {

	[SerializeField]
	private int level;

	public int GetLevel() {
		return level;
	}

	public void AddLevel(int AddLevel) {
		level += AddLevel;
	}
}
