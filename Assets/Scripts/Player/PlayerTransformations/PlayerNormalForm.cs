using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerNormalForm : PlayerTransform {

	Rigidbody rb;
	PlayerAiming playerAim;
	AbilityState currentAbilityState;
	Collider meleeBox;
	Collider aoeBox;
	Transform parentHitBox;
	GameObject aoeParticleEffect;
	ParticleSystem dashParticleEffect;
	RaycastHit hit;
	float rayDist = 20.0f;
	Vector3 rayDir = new Vector3 (0, -1, 0);

	public float cooldown1;
	public bool isCooling1 = false;
	public float cooldown2;
	public bool isCooling2 = false;
	public float cooldown3;
	public bool isCooling3 = false;
	List<GameObject> dashHitList;

	void Awake () {
		rb = GetComponent<Rigidbody> ();
		playerAim = rb.GetComponent<PlayerAiming> ();
		dashHitList = new List <GameObject> ();
		meleeBox = transform.FindChild ("MeleeHitBoxes/MeleeHitBoxFront").GetComponent<Collider>();
		aoeBox = transform.FindChild ("MeleeHitBoxes/AOEHitbox").GetComponent<BoxCollider> ();

		dashParticleEffect = transform.FindChild ("PlayerArm/Normal_Dash_Particle_Effect").gameObject.GetComponent <ParticleSystem> ();
		aoeParticleEffect = Resources.Load ("Prefabs/Abilities/ParticleEffects/Normal_Special_Ability_Effect") as GameObject;
		transform_name = "Normal";
		transform_description = "What his momma gave him.";
		cooldown1 = 0.25f;
		cooldown2 = 1.0f;
		cooldown3 = 3.0f;
		currentAbilityState = AbilityState.IDLE;
	}

	void Update () {

		switch (currentAbilityState) {

		case AbilityState.DASHING:
			for (int i= 0; i < meleeBox.GetComponent<MeleeHitBox> ().currentCols.Count; i++) {
                GameObject obj = meleeBox.GetComponent<MeleeHitBox>().currentCols[i];
				if (obj != null && obj.tag == "Enemy" & !dashHitList.Contains (obj)) {
					Debug.Log ("I dashed a dude!");
					obj.GetComponent<EnemyHealth> ().addDamage (5);
					dashHitList.Add (obj);
				}
                if (obj != null & obj.tag == "IceWall")
                {
                    if(obj.GetComponent<BreakIceWall>() != null)
                     obj.GetComponent<BreakIceWall>().SetHit();
                    meleeBox.GetComponent<MeleeHitBox>().currentCols.Remove(obj);
                }
			}
			break;
		}
	}

	public override void Ability1() {
		Debug.Log ("Normal Ability 1");
		punch ();
	}

	public override void Ability2() {
		Debug.Log ("Normal Ability 2");
		dash ();
	}

	public override void SpecialAbility() {
		Debug.Log ("Normal Special Ability");
		groundSlam ();
	}

	private void punch () {
		if (!isCooling1) {
			foreach (GameObject obj in meleeBox.GetComponent<MeleeHitBox> ().currentCols) {
				if (obj != null && obj.tag == "Enemy") {
					Debug.Log ("I punched a dude!");
					obj.GetComponent<EnemyHealth> ().addDamage (5);
				}

				if (obj.gameObject.CompareTag ("IceWall")) {
					obj.gameObject.GetComponent<BreakIceWall> ().SetHit ();
				}
			}
			isCooling1 = true;
			Invoke ("resetCooling1", cooldown1);
		}
	}
		
	private void dash () {
		if (!isCooling2) {
			Vector3 dashDir = (playerAim.mouse_pos - transform.position).normalized;

			currentAbilityState = AbilityState.DASHING;
			dashParticleEffect.Play ();
			rb.velocity = Vector3.zero;
			rb.AddForce (new Vector3 (dashDir.x * 600f, dashDir.y * 600f, 0f));
			isCooling2 = true;
			Invoke ("resetCooling2", cooldown2);
			Debug.Log ("DASHING THROUGH THE SNOW!!!");
		}
	}
		
	private void groundSlam () {
		if (!isCooling3) {
			if (Physics.Raycast (rb.transform.position, rayDir, out hit, rayDist)) {
				Instantiate (aoeParticleEffect, new Vector3 (rb.position.x, hit.point.y, rb.position.z), Quaternion.identity);
				foreach (GameObject obj in aoeBox.GetComponent<MeleeHitBox> ().currentCols) {
					if (obj != null && obj.tag == "Enemy") {
						Debug.Log ("I normal specialed dudes!");
						obj.GetComponent<EnemyHealth> ().addDamage (20);
					}

					if (obj.gameObject.CompareTag ("IceWall")) {
						obj.gameObject.GetComponent<BreakIceWall> ().SetHit ();
					}
				}
				isCooling3 = true;
				Invoke ("resetCooling3", cooldown3);
			}
		}
	}

	private void resetCooling1 () {
		isCooling1 = false;
	}

	private void resetCooling2 () {
		isCooling2 = false;
		dashHitList.Clear ();
		currentAbilityState = AbilityState.IDLE;
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

    private void resetCooling3()
    {
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

	public enum AbilityState {
		IDLE,
		DASHING
	}
}
