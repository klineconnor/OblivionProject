using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatValuePerception : MonoBehaviour 
{
	Text currentValue;
	Stat stat;

	void Start()
	{
		currentValue = GetComponent<Text>();
		stat = PlayerStats.Instance.Perception;
	}
	void Update()
	{
		currentValue.text = stat.GetStat().ToString();
	}
}
