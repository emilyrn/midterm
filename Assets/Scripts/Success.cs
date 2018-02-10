using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Success : MonoBehaviour {

	public GameObject success;
	public ParticleSystem successParticle;
	public AudioClip successSound;
	// Use this for initialization

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			AudioSource.PlayClipAtPoint (successSound, transform.position, 1.0f);
			successParticle.Play ();
		}
	}

}
