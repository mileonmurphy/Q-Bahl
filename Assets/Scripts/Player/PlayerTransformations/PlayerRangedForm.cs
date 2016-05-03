using UnityEngine;
using System.Collections;

public class PlayerRangedForm : PlayerTransform {

	GameObject laserBeamObject;
	GameObject laserBeamClone;
	Transform playerArm;
	PlayerAiming playerAim;

	public float cooldown1;
	public bool isCooling1 = false;
	public float cooldown2;
	public bool isCooling2 = false;
	public float cooldown3;
	public bool isCooling3 = false;

	void Awake () {
		playerAim = GetComponent<PlayerAiming> ();
		laserBeamObject = Resources.Load ("Prefabs/Abilities/LaserBeam") as GameObject;
		playerArm = transform.FindChild ("PlayerArm");
		transform_name = "Ranged";
		transform_description = "I'm over here.";
	}
	
	public override void Ability1() {
		Debug.Log ("Normal Ability 1");
	}
	
	public override void Ability2() {
		Debug.Log ("Normal Ability 2");
		shootBeamLaser ();
	}
	
	public override void SpecialAbility() {
		Debug.Log ("Normal Special Ability");
	}

	void shootBeamLaser () {
		if (!isCooling2) {
			Vector3 laserDir = (playerAim.mouse_pos - transform.position).normalized;
			laserBeamClone = (GameObject) Instantiate (laserBeamObject, playerArm.position, Quaternion.Euler (0, 0, 0));
			laserBeamClone.transform.localRotation = Quaternion.Euler ( -1 * playerAim.turn_angle, 90, 0);
			Debug.Log (laserBeamClone.transform.localRotation);

			isCooling2 = true;
			Invoke ("resetCooling2", 1);
		}
	}

	private void resetCooling1 () {
		isCooling1 = false;
	}

	private void resetCooling2 () {
		isCooling2 = false;
	}

	private void resetCooling3 () {
		isCooling3 = false;
	}

}
