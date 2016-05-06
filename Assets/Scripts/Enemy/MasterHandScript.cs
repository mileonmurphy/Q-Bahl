using UnityEngine;
using System.Collections;

public class MasterHandScript : MonoBehaviour {

	BossState currState;

	GameObject player;

	Vector3 dist;
	Vector3 playerPos;

	float moveMult;
	float idleMoveSpeed = 7f;
	float resetMoveSpeed = 1f;

	bool closeLaserCooling;

	// Use this for initialization
	void Start () {
		currState = BossState.IDLE;
		player = (GameObject) GameObject.FindGameObjectWithTag ("Player");
		Invoke ("setResetState", 4);

		// Set initial bools
		closeLaserCooling = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (player.transform.position);

		// States Machine
		switch (currState) {
		case BossState.IDLE:
			
			break;
		case BossState.RESET_TO_PLAYER:
			resetToPlayer ();
			break;
		case BossState.ATTACKING:
			break;
		}
	}

	void laserClosePlayer () {
		dist = transform.position - player.transform.position;
		if (!closeLaserCooling) {
			if (Mathf.Abs (dist.x) < 5f) {
				fireMiddleLaser ();
				closeLaserCooling = true;
				Invoke ("resetCoolingCloseLaser", 5);
			}
		}
	}

	void fireMiddleLaser () {
		
	}

	void resetCoolingCloseLaser () {
		closeLaserCooling = false;
	}

	void resetToPlayer () {
		dist = transform.position - player.transform.position;
		if (dist.x > 0)
			moveMult = 1;
		else
			moveMult = -1;
		playerPos = player.transform.position;
		transform.position = Vector3.Lerp(transform.position, new Vector3 (playerPos.x + (25f * moveMult), playerPos.y + 10f, playerPos.z), Time.deltaTime * resetMoveSpeed);
		if (!IsInvoking ("setIdleState")) {
			Invoke ("setIdleState", 4);
		}
	}

	void setResetState () {
		currState = BossState.RESET_TO_PLAYER;
	}

	void setIdleState () {
		currState = BossState.IDLE;
	}

	enum BossState {
		IDLE,
		RESET_TO_PLAYER,
		ATTACKING
	}
}
