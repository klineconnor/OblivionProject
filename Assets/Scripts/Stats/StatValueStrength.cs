using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatValueStrength : MonoBehaviour 
{
	Text currentValue;
	Stat stat;

	void Start()
	{
		currentValue = GetComponent<Text>();
		stat = PlayerStats.Instance.Strength;
	}
	void Update()
	{
		currentValue.text = stat.GetStat().ToString();
	}
}
