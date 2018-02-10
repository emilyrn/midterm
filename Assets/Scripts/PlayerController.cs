using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;
	public Vector3 jump;
	public float jumpForce = 2.0f;


	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {

			rb.AddForce (jump * jumpForce, ForceMode.Impulse);
			//rb.AddForce(new Vector3(0, jumpForce));
		}
	}


	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
}