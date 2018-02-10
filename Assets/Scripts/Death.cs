using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	public AudioClip deathSound;
	public ParticleSystem deathParticle;

	private void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Player") {
			AudioSource.PlayClipAtPoint (deathSound, transform.position, 1.0f);
			deathParticle.Play ();
			Object.Destroy (col.gameObject);
		}
	}
}