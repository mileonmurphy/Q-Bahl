using UnityEngine;
using System.Collections;

public class PlayerNormalForm : PlayerTransform {

	public Rigidbody rb;
	public BoxCollider meleeBox;
	public float cooldown1;
	public bool isCooling1 = false;
	public float cooldown2;
	public bool isCooling2 = false;
	public float cooldown3;
	public bool isCooling3 = false;

	void Awake () {
		transform_name = "Normal";
		transform_description = "What his momma gave him.";
		cooldown1 = 0.25f;
		cooldown2 = 1.0f;
		cooldown3 = 2.0f;
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
	}

	private void punch () {
		if (!isCooling1) {
			foreach (GameObject obj in meleeBox.GetComponent<MeleeHitBox> ().currentCols) {
				if (obj != null && obj.tag == "Enemy") {
					Debug.Log ("I punched a dude!");
					obj.GetComponent<EnemyHealth> ().addDamage (5);
				}
			}
			isCooling1 = true;
			Invoke ("resetCooling1", cooldown1);
		}
	}
		
	private void dash () {
		if (!isCooling2) {
			bool lookingRight = rb.GetComponent<PlayerAiming> ().looking_right;
			if (lookingRight) {
				rb.velocity = Vector3.zero;
				rb.AddForce (new Vector3 (500f, 0, 0));
			} else {
				rb.velocity = Vector3.zero;
				rb.AddForce (new Vector3 (-500f, 0, 0));
			}
			isCooling2 = true;
			Invoke ("resetCooling2", cooldown2);
			Debug.Log ("DASHING THROUGH THE SNOW!!!");
		}
	}


	private void groundSlam () {
		
	}

	private void resetCooling1 () {
		isCooling1 = false;
	}

	private void resetCooling2 () {
		isCooling2 = false;
	}

	private void reset3Cooling3 () {
		isCooling3 = false;
	}
}
