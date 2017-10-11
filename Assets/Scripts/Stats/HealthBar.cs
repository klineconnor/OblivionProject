using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	PlayerStats playerStats;
	Slider slider;
	void Start () {
		playerStats = PlayerStats.Instance;
		slider = GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		slider.maxValue = playerStats.GetMaxHealth ();
		slider.value = playerStats.GetCurrentHealth();
	}
}
