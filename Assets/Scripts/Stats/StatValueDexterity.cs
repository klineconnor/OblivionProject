using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatValueDexterity : MonoBehaviour 
{
	Text currentValue;
	Stat stat;

	void Start()
	{
		currentValue = GetComponent<Text>();
		stat = PlayerStats.Instance.Dexterity;
	}
	void Update()
	{
		currentValue.text = stat.GetStat().ToString();
	}
}
