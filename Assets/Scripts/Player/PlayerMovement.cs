using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public static float speed  = 8f;
	public float jumpForce = 300f;
	private bool isGrounded = false;

	Vector3 movement;
	Rigidbody playerRigidbody;
	RaycastHit hit;
	Vector3 rayDir = new Vector3 (0f, -1f, 0f);
	float rayDist = 0.8f;



	// Use this for initialization
	void Awake () {
		// This will be used to rotate the player's aim/arm/gun around the z-axis
		playerRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per physics frame
	void FixedUpdate () {
		if (GameObject.Find ("GameManager").GetComponent<GameManager> ().GetCurrGameState() != GAME_STATE.START_MENU && GameObject.Find ("GameManager").GetComponent<GameManager> ().GetCurrGameState() != GAME_STATE.PAUSED) {
			float h = Input.GetAxisRaw ("Horizontal");

			Move (h);
			if (isGrounded && Input.GetKeyDown ("space")) {
				isGrounded = false;
				Jump ();
			}
		}
	}

	void Move(float h) {
		movement.Set (h, 0f, 0f);
		movement = movement.normalized * speed * Time.deltaTime;
		playerRigidbody.MovePosition (transform.position + movement);
	}

	void Jump() {
		playerRigidbody.AddForce (transform.up * jumpForce);
	}
		
	void OnCollisionEnter(Collision other) {
		if (Physics.Raycast (transform.position, rayDir, out hit, rayDist)) {
			isGrounded = true;
		}
	}

	public void ChangeSpeed(float num){
		speed *= num;
	}

	public void ResetNormal(){
		speed = 8f;
	}
}
