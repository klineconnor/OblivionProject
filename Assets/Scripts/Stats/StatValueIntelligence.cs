using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatValueIntelligence : MonoBehaviour 
{
	Text currentValue;
	Stat stat;

	void Start()
	{
		currentValue = GetComponent<Text>();
		stat = PlayerStats.Instance.Intelligence;
	}
	void Update()
	{
		currentValue.text = stat.GetStat().ToString();
	}
}
