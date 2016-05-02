using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HailStormHailScript : MonoBehaviour {

	Rigidbody rb;
	List<string> TagChecks = new List<string> {"Player", "Player_Hitbox"};


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3 (1,-25, 0);
		Invoke ("autoDestroy", 2);
	}

	void OnCollisionEnter (Collision col) {
		if (!TagChecks.Contains (col.gameObject.tag)) {
			if (col.gameObject.CompareTag("Enemy")) {
				col.gameObject.GetComponent<EnemyHealth> ().addDamage (2);
				Destroy (this.gameObject);
			}
		}
	}

	void autoDestroy () {
		Destroy (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
