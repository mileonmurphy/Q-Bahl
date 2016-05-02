using UnityEngine;
using System.Collections;

public class RockWallScript : MonoBehaviour {

	RockWallState currState;
	Vector3 originalPos;
	float step; 
	// Use this for initialization
	void Start () {
		originalPos = transform.position;
		transform.position = new Vector3 (transform.position.x, transform.position.y - 5, transform.position.z);
		currState = RockWallState.RISING;
	}
	
	// Update is called once per frame
	void Update () {
		switch (currState) {
		case RockWallState.RISING:
			step = 2 * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, new Vector3 (transform.position.x, transform.position.y + 5, transform.position.z), step);
			if (transform.position.y >= originalPos.y) {
				currState = RockWallState.IDLE;
				Invoke ("beginDespawn", 5);
			}
			break;
		case RockWallState.DESCENDING:
			step = 2 * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, new Vector3 (transform.position.x, transform.position.y + 5, transform.position.z), step);
			if (transform.position.y <= originalPos.y - 5) {
				Destroy (this);
			}
			break;
		}
	}

	private void beginDewspawn () {
		currState = RockWallState.DESCENDING;
	}

	private enum RockWallState {
		IDLE,
		RISING,
		DESCENDING
	}
}
