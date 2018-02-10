using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour {

	private NavMeshAgent agent;
	public GameObject target;
	Vector3 destination;


	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		destination = agent.destination;

	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination(target.transform.position);
	
}
}
