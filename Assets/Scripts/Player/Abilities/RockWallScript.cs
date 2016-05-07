using UnityEngine;
using System.Collections;

public class RockWallScript : MonoBehaviour {

	public GameObject mudEffect;

	GameObject instMudEffect;
	RockWallState currState;
	Vector3 originalPos;
	float step;

	// Use this for initialization
	void Start () {
		originalPos = transform.position;
		transform.position = new Vector3 (transform.position.x, transform.position.y - 5, transform.position.z);
		instMudEffect = (GameObject) Instantiate (mudEffect, new Vector3 (transform.position.x, transform.position.y + 5, transform.position.z), Quaternion.identity);
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
				instMudEffect.GetComponent<ParticleSystem> ().Stop ();
				Invoke ("beginDespawn", 5);
			}
			break;
		case RockWallState.DESCENDING:
			step = 2 * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, new Vector3 (transform.position.x, transform.position.y - 5, transform.position.z), step);
			if (transform.position.y <= originalPos.y - 5) {
				if (instMudEffect.GetComponent<ParticleSystem> ().isStopped) {
					Destroy (instMudEffect);
					Destroy (this.gameObject);
				} else {
					instMudEffect.GetComponent<ParticleSystem> ().Stop ();
				}
			}
			break;
		}
	}

	private void beginDespawn () {
		currState = RockWallState.DESCENDING;
		instMudEffect.GetComponent<ParticleSystem> ().Play ();
	}

	private enum RockWallState {
		IDLE,
		RISING,
		DESCENDING
	}
}
