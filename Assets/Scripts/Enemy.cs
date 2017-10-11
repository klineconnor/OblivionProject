using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

	NavMeshAgent agent;
	public float radius;
	float distance;
	Transform player;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		player = CharacterManager.Instance.character.transform;
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (transform.position, player.position);
		if (distance <= radius) {
			agent.destination = player.position;
		}
	}

	void OnDrawGizmosSelected() {
		Gizmos.DrawWireSphere (transform.position, radius);
	}

}
