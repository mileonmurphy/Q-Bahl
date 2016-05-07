using UnityEngine;
using System.Collections;

public class PlayerAiming : MonoBehaviour {
	public GameObject playerArm;

	public Vector3 mouse_pos;
	Vector3 arm_pos;
	public float turn_angle;
    public bool looking_right;
	public float x, y;

    void Awake () {
        looking_right = true;
    }
	// Update is called once per frame
	void FixedUpdate () {
		Turn ();
	}

	void Turn () {

		x = Input.GetAxis ("Xbox360ControllerRightX");
		y = Input.GetAxis ("Xbox360ControllerRightY");

		if (x != 0.0f || y != 0.0f) {
			turn_angle = Mathf.Atan2 (y, x) * Mathf.Rad2Deg;
		}
		//arm_pos = Camera.main.WorldToScreenPoint (playerArm.transform.position);
		//playerArm.transform.rotation = Quaternion.Euler (new Vector3 (0, 0, turn_angle));
		if (PlayerMovement.facingRight) {
			playerArm.transform.rotation = Quaternion.Euler (new Vector3 (0, 0, -turn_angle));
		} else {
			playerArm.transform.rotation = Quaternion.Euler (new Vector3 (0, 0, turn_angle));
		}
//        if (Mathf.Abs(turn_angle) > 90 && looking_right) {
//            looking_right = false;
//            Flip ();
//        } else if (Mathf.Abs(turn_angle) < 90 && !looking_right) {
//            looking_right = true;
//            Flip ();
//        }
	}


}
