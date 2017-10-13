using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroadSword : MonoBehaviour {

	Animator anim;
	bool draw = false;
	public int BaseAttack;
	PlayerStats playerStats;


	void Start () {
		anim = GetComponent<Animator> ();
		playerStats = PlayerStats.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Draw")) {
			draw = !draw;
			anim.SetBool ("Draw", draw);
		}
		if (Input.GetButtonDown ("Attack")) {
			Debug.Log ("Attack!");
			anim.SetTrigger ("Attack");
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.GetComponent<Enemy> () != null) {

		}
	}
}
