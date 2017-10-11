using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroadSword : MonoBehaviour {

	Animator anim;
	bool draw = false;
	int BaseAttack;


	void Start () {
		anim = GetComponent<Animator> ();
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

	public void SetBaseAttack(int SetAttack) {
		BaseAttack = SetAttack;
	}

	public int GetAttack() {
		int trueAttack;
		return trueAttack;
	}

	void OnTriggerEnter(Collider other) {
		if (other.GetComponent<Enemy> () != null) {

		}
	}
}
