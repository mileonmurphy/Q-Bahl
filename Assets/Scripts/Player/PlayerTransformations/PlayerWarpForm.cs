using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerWarpForm : PlayerTransform {

	GameObject player;
	GameObject slowDownBubble;
	GameObject speedUpBubble;
	GameObject currSlowBubble;
	GameObject currSpeedBubble;
	BoxCollider slowCol;
	BoxCollider speedCol;
	BoxCollider playerArm;
	public ParticleSystem teleEffect1;
	public ParticleSystem teleEffect2;
	MeleeHitBox hb;

	List<GameObject> slowDownObjs;
	List<GameObject> speedUpObjs;
	 
	PlayerAiming playerAim;
	Rigidbody rb;

	RaycastHit hit;

	int layerMask = 2 << 8;

	float teleportLength = 10.0f;
	float cooldown1;
	float cooldown2;
	float cooldown3;

	bool isCooling1;
	bool isCooling2;
	bool isCooling3;

	void Awake () {
		transform_name = "Warp";
		transform_description = "Where, what, meow?";
		playerArm = GameObject.Find ("PlayerArm").GetComponent<BoxCollider>();
		hb = playerArm.GetComponent<MeleeHitBox> ();
		playerAim = GetComponent<PlayerAiming> ();
		rb = GetComponent<Rigidbody> ();

		cooldown1 = 3.0f;
		cooldown2 = 6.0f;
		cooldown3 = 6.0f;

		isCooling1 = false;
		isCooling2 = false;
		isCooling3 = false;
	}

	void Start () {
		slowDownBubble = Resources.Load ("Prefabs/Abilities/SlowDownBubble") as GameObject;
		speedUpBubble = Resources.Load ("Prefabs/Abilities/SpeeedUpBubble") as GameObject;
//		teleEffect1 = Resources.Load ("Prefabs/Abilities/SpeeedUpBubble") as GameObject;
//		teleEffect2 = Resources.Load ("Prefabs/Abilities/SpeeedUpBubble") as GameObject;

	}

	public override void Ability1() {
		Debug.Log ("Warp Ability 1");
		MakeSpeedUpBubble ();
	}
	public override void Ability2() {
		Debug.Log ("Warp Ability 2");
		MakeSlowDownBubble ();
	}
	public override void SpecialAbility() {
		Debug.Log ("Warp Special Ability");
		Teleport ();
	}

	private void Teleport(){
		Vector3 telDir;
		if (!isCooling3) {
			for (int i = 0; i < hb.currentCols.Count; i++) {
				GameObject currCol = hb.currentCols [i].gameObject;
				if (((new Vector3 (currCol.transform.position.x, currCol.transform.position.y, currCol.transform.position.z) - transform.position).normalized * Mathf.Abs ((currCol.transform.position - transform.position).magnitude)).magnitude >= 1) {
					telDir = (new Vector3 (currCol.transform.position.x, currCol.transform.position.y, currCol.transform.position.z) - transform.position).normalized * Mathf.Abs ((currCol.transform.position - transform.position).magnitude - 5);
				} else {
					telDir = new Vector3 (0, 0, 0);
				}
			}
			//checks out, cool start doing stuff
			telDir = transform.position + ((new Vector3(playerAim.mouse_pos.x, playerAim.mouse_pos.y,transform.position.z) - transform.position).normalized * teleportLength);
			teleEffect1.Play ();
			teleEffect2.Play ();
			transform.position = new Vector3 (telDir.x, telDir.y, telDir.z);
			Invoke ("EndTeleParticles", 2f);
			Invoke ("ResetCooling3", cooldown3);
			isCooling3 = true;
		}
	}

	private void EndTeleParticles(){
		teleEffect1.Stop ();
		teleEffect2.Stop ();
		teleportLength = 10.0f;
	}

	private void MakeSlowDownBubble(){
		if (!isCooling2) {
			currSlowBubble = (GameObject)Instantiate (slowDownBubble, transform.position, new Quaternion (0, 0, 0, 0));
			Invoke ("DestroySlowDownBubble",cooldown2);
			Invoke ("ResetCooling2", cooldown2);
			isCooling2 = true;
		} else {
			//get all objects in scene touching the collider
		}
	}

	private void MakeSpeedUpBubble(){
		if (!isCooling1) {
			currSpeedBubble = (GameObject)Instantiate (speedUpBubble, transform.position, new Quaternion (0, 0, 0, 0));
			Invoke ("DestroySpeedUpBubble", cooldown1);
			Invoke ("ResetCooling1", cooldown1);
			isCooling1 = true;
		} else {
			//get all objects in scene touching the collider
		}
	}

	private void DestroySpeedUpBubble(){
		Destroy (currSpeedBubble);
		GetComponent<PlayerMovement> ().ResetNormal ();
		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		for (int i = 0; i < enemies.Length; i++) {
			if(	enemies [i].GetComponent<AirEnemyMovement> () != null)
				enemies [i].GetComponent<AirEnemyMovement> ().ResetNormal ();
			if(	enemies [i].GetComponent<GroundEnemyMovement> () != null)
				enemies [i].GetComponent<GroundEnemyMovement> ().ResetNormal ();
		}
	}

	private void DestroySlowDownBubble(){
		Destroy (currSlowBubble);
		GetComponent<PlayerMovement> ().ResetNormal ();
		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		for (int i = 0; i < enemies.Length; i++) {
			if(	enemies [i].GetComponent<AirEnemyMovement> () != null)
				enemies [i].GetComponent<AirEnemyMovement> ().ResetNormal ();
			if(	enemies [i].GetComponent<GroundEnemyMovement> () != null)
				enemies [i].GetComponent<GroundEnemyMovement> ().ResetNormal ();
		}
	}

	void ResetCooling1(){
		isCooling1 = false;
	}

	void ResetCooling2(){
		isCooling2 = false;
	}

	void ResetCooling3(){
		isCooling3 = false;
	}

    public float getCooling1Time()
    {
        return cooldown1;
    }

    public float getCooling2Time()
    {
        return cooldown2;
    }

    public float getCooling3Time()
    {
        return cooldown3;
    }

    public bool getCooling3()
    {
        return isCooling3;
    }

    public bool getCooling1()
    {
        return isCooling1;
    }

    public bool getCooling2()
    {
        return isCooling2;
    }

}
