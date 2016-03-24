using UnityEngine;
using System.Collections;

public class PlayerAiming : MonoBehaviour {
	public GameObject playerArm;

	Vector3 mouse_pos;
	Vector3 arm_pos;
	private float turn_angle;
    private bool looking_right;

    void Awake () {
        looking_right = true;
    }
	// Update is called once per frame
	void FixedUpdate () {
		Turn ();
	}

	void Turn () {
		mouse_pos = Input.mousePosition;
		arm_pos = Camera.main.WorldToScreenPoint (playerArm.transform.position);
		mouse_pos.x = mouse_pos.x - arm_pos.x;
		mouse_pos.y = mouse_pos.y - arm_pos.y;
		mouse_pos.z = 0f;
		turn_angle = Mathf.Atan2 (mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
		playerArm.transform.rotation = Quaternion.Euler (new Vector3 (0, 0, turn_angle));
        if (Mathf.Abs(turn_angle) > 90 && looking_right) {
            looking_right = false;
            RotatePlayer ();
        } else if (Mathf.Abs(turn_angle) < 90 && !looking_right) {
            looking_right = true;
            RotatePlayer ();
        }
	}
    
    void RotatePlayer () {
        if (!looking_right) {
            transform.rotation = Quaternion.Euler (new Vector3 (0, 180, 0));
        } else {
            transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));
        }
    }
}
