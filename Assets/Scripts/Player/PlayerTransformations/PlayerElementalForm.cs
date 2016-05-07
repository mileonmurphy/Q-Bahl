using UnityEngine;
using System.Collections;

public class PlayerElementalForm : PlayerTransform {


	GameObject rockWallObject;
	GameObject fireball;
	GameObject hailStormObject;
	Rigidbody rb;
	Rigidbody fireballRb;
	PlayerAiming playerAim;
	Vector3 rayDir = new Vector3 (0, -1, 0);
	RaycastHit hit;
	float rayDist = 20.0f;
	public float turnAngle;
	public float fireballSpeed = 1000f;
	float rockWallDir;


	// Cooldown Variables
	public float cooldown1;
	public bool isCooling1 = false;
	public float cooldown2;
	public bool isCooling2 = false;
	public float cooldown3;
	public bool isCooling3 = false;

	void Awake () {
		rb = GetComponent<Rigidbody> ();
		playerAim = rb.GetComponent<PlayerAiming> ();
		fireball = Resources.Load ("Prefabs/Abilities/Fireball_Ability") as GameObject;
		rockWallObject = Resources.Load("Prefabs/Abilities/Rock Wall") as GameObject;
		hailStormObject = Resources.Load ("Prefabs/Abilities/Hail Storm") as GameObject;
		transform_name = "Elemental";
		transform_description = "Avatar yo.";
		cooldown1 = 1.0f;
		cooldown2 = 5.0f;
		cooldown3 = 6.0f;
	}
	
	public override void Ability1() {
		Debug.Log ("Elemental Ability 1");
		shootFireball ();
	}
	
	public override void Ability2() {
		Debug.Log ("Elemental Ability 2");
		rockWall ();
	}
	
	public override void SpecialAbility() {
		Debug.Log ("Elemental Special Ability");
		hailStorm ();
	}

	private void shootFireball () {
		if (!isCooling1) {
			isCooling1 = true;
			GameObject fireballClone = (GameObject) Instantiate (fireball, new Vector3 (rb.position.x, rb.position.y, rb.position.z), Quaternion.identity);
			fireballRb = fireballClone.GetComponent<Rigidbody> ();

			Vector3 fbDir = (playerAim.mouse_pos - fireball.transform.position).normalized;
			fireballRb.velocity = new Vector3 (fbDir.x * 15f, fbDir.y * 15f, rb.position.z);

			Invoke ("resetCooling1", cooldown1);
		}
	}

	private void rockWall () {
		if (!isCooling2) {
			if (Physics.Raycast (rb.transform.position, rayDir, out hit, rayDist)) {
				if (playerAim.looking_right) {
					rockWallDir = 5f;
				} else {
					rockWallDir = -5f;
				}
				Instantiate (rockWallObject, new Vector3 (rb.position.x + rockWallDir, hit.point.y, rb.position.z), Quaternion.Euler(0,90,0));
				isCooling2 = true;
				Invoke ("resetCooling2", cooldown2);
			}
		}
	}

	private void hailStorm () {
		if (!isCooling3) {
			if (playerAim.looking_right) {
				rockWallDir = 5f;
			} else {
				rockWallDir = -5f;
			}
			Instantiate (hailStormObject, new Vector3 (rb.position.x + rockWallDir, rb.position.y + 10f, rb.position.z), Quaternion.identity);
			isCooling3 = true;
			Invoke ("resetCooling3", cooldown3);
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

    public bool getCooling1()
    {
        return isCooling1;
    }

    public bool getCooling2()
    {
        return isCooling2;
    }

    public bool getCooling3()
    {
        return isCooling3;
    }

}
