using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {


	public int Health;
	public int Attack;
	public int Defense;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame




	public void Damage(int attack)
	{
		Debug.Log("Enemy Attack");
		rb.AddForce(new Vector3(1.0f, 0.0f, 0.0f), ForceMode.Impulse);
		Health = Health - (attack / Defense);
		if (Health <= 0)
		{
			Die();
		}
	}

	public void Die()
	{
		GetComponent<EnemyAI>().enabled = false;
		GetComponent<NavMeshAgent>().enabled = false;	}
}
