using UnityEngine;
using System.Collections;

public class MasterHandScript : MonoBehaviour {

	BossState currState;

	GameObject player;

	Vector3 dist;
	Vector3 playerPos;
	Vector3 smashTargetPosition;

	float moveMult;
	float idleMoveSpeed = 7f;
	float resetMoveSpeed = 1f;
	float smashSearchMoveSpeed = 2f;
	float smashMoveSpeed = 5f;
	float playerMoveDir;
	GameObject fingerIndex;
	GameObject fingerMiddle;
	GameObject fingerRing;
	GameObject fingerPinky;
	GameObject fingerThumb;
	PlayerMovement playerMoveComp;

	RaycastHit[] hits;

	bool closeLaserCooling;

	// Use this for initialization
	void Start () {
		currState = BossState.IDLE;
		player = (GameObject) GameObject.FindGameObjectWithTag ("Player");
		playerMoveComp = player.GetComponent<PlayerMovement> ();
		playerMoveDir = playerMoveComp.movementDir;

		// Get fingers
		fingerIndex = transform.FindChild ("FingerIndex").gameObject;
		fingerMiddle = transform.FindChild ("FingerMiddle").gameObject;
		fingerRing = transform.FindChild ("FingerRing").gameObject;
		fingerPinky = transform.FindChild ("FingerPinky").gameObject;
		fingerThumb = transform.FindChild ("FingerThumb").gameObject;


		// Set initial bools
		closeLaserCooling = false;

		Invoke ("setSmashSearchState", 4);

	}
	
	// Update is called once per frame
	void Update () {

		// States Machine
		switch (currState) {
		case BossState.IDLE:
			transform.LookAt (player.transform.position);
			laserClosePlayer ();
			break;
		case BossState.RESET_TO_PLAYER:
			resetToPlayer ();
			break;
		case BossState.ATTACKING:
			break;
		case BossState.SMASH_SEARCH:
			smashSearch ();
			break;
		case BossState.SMASH:
			smashMove ();
			break;
		}
	}

	/*
		LASER MOVES
	*/

	void laserClosePlayer () {
		dist = transform.position - player.transform.position;
		if (!closeLaserCooling) {
			if (Mathf.Abs (dist.x) < 15f) {
				fireMiddleLaser ();
				closeLaserCooling = true;
				Invoke ("resetCoolingCloseLaser", 5);
			}
		}
	}

	public void shootLazer(GameObject lazerSource)
	{
		setDistDir ();
		
		LineRenderer lr = gameObject.AddComponent<LineRenderer>();
		lr.SetVertexCount(2);
		lr.material = new Material (Shader.Find("Particles/Additive"));
		lr.SetColors(Color.red, Color.magenta);
		lr.SetPosition(0, lazerSource.transform.position);
		lr.SetPosition(1, player.transform.position);
		lr.SetWidth(0.3f, 0.2f);
		// Raycast dat shiz
		hits = Physics.RaycastAll (transform.position, transform.forward, 20f);
		foreach (RaycastHit hit in hits) {
			if (hit.transform.CompareTag ("Player")) {
				hit.transform.gameObject.GetComponent<PlayerHealth> ().TakeDamage (5);
				player.GetComponent<Rigidbody> ().AddForce (new Vector3(-250f * moveMult, 0, 0));
			}
		}
		Invoke("destroyLazer", 0.2f);
	}

	public void destroyLazer()
	{
		Destroy(GetComponent<LineRenderer>());
	}

	void fireMiddleLaser () {
		shootLazer (fingerMiddle.transform.FindChild ("FingerTip").gameObject);
	}

	void resetCoolingCloseLaser () {
		closeLaserCooling = false;
	}

	/*
		SMASH MOVES
	*/

	void smashSearch () {
		setDistDir ();
		
		playerPos = player.transform.position;
		transform.position = Vector3.Lerp(transform.position, new Vector3 (playerPos.x + (3 * playerMoveDir), playerPos.y + 15f, playerPos.z), Time.deltaTime * smashSearchMoveSpeed);
		smashTargetPosition = playerPos;
		if (!IsInvoking ("setSmashState")) {
			Invoke ("setSmashState", 6);
		}
	}

	void smashMove () {
		transform.position = Vector3.Lerp(transform.position, smashTargetPosition, Time.deltaTime * smashMoveSpeed);

		if (!IsInvoking ("setResetState")) {
			Invoke ("setResetState", 4);
		}
	}


		
	void resetToPlayer () {
		setDistDir ();
		playerPos = player.transform.position;
		transform.position = Vector3.Lerp(transform.position, new Vector3 (playerPos.x + (25f * moveMult), playerPos.y + 10f, playerPos.z), Time.deltaTime * resetMoveSpeed);
		if (!IsInvoking ("setIdleState")) {
			Invoke ("setIdleState", 4);
		}
	}

	void setDistDir () {
		playerMoveDir = playerMoveComp.movementDir;
		dist = transform.position - player.transform.position;
		if (dist.x > 0)
			moveMult = 1;
		else
			moveMult = -1;
	}

	/*
		STATE SETTERS
	*/
	void setResetState () {
		currState = BossState.RESET_TO_PLAYER;
	}

	void setIdleState () {
		currState = BossState.IDLE;
	}

	void setSmashSearchState () {
		currState = BossState.SMASH_SEARCH;
	}

	void setSmashState () {
		currState = BossState.SMASH;
	}



	enum BossState {
		IDLE,
		RESET_TO_PLAYER,
		SMASH_SEARCH,
		SMASH,
		ATTACKING
	}
}
