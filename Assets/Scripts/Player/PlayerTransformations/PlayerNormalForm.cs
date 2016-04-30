using UnityEngine;
using System.Collections;

public class PlayerNormalForm : PlayerTransform {

	public Rigidbody rb;
	public float cooldown1 = 0.05f;
	public bool isCooling1 = false;
	public float cooldown2 = 0.05f;
	public bool isCooling2 = false;
	public float cooldown3 = 0.05f;
	public bool isCooling3 = false;

	void Awake () {
		transform_name = "Normal";
		transform_description = "What his momma gave him.";
	}

	public override void Ability1() {
		Debug.Log ("Normal Ability 1");
	}

	public override void Ability2() {
		Debug.Log ("Normal Ability 2");
		dash ();
	}

	public override void SpecialAbility() {
		Debug.Log ("Normal Special Ability");
	}

	private void dash () {
		if (isCooling1 == false) {
			bool lookingRight = rb.GetComponent<PlayerAiming> ().looking_right;
			if (lookingRight) {
				rb.AddForce (new Vector3 (500f, 0, 0));
			} else {
				rb.AddForce (new Vector3 (-500f, 0, 0));
			}
			isCooling1 = true;
			Invoke ("resetCooling1", cooldown1);
		}
	}

	private void resetCooling1 () {
		isCooling1 = false;
	}

	private void resetCooling2 () {
		isCooling2= false;
	}

	private void reset3Cooling3 () {
		isCooling3 = false;
	}
}
