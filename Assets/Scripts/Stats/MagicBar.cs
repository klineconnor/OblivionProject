using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicBar : MonoBehaviour {

	PlayerStats playerStats;
	Slider slider;
	void Start () {
		playerStats = PlayerStats.Instance;
		slider = GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		slider.maxValue = playerStats.GetMaxMagic();
		slider.value = playerStats.GetCurrentMagic();
	}
}
