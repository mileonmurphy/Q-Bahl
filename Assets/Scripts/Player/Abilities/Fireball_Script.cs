using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Fireball_Script : MonoBehaviour {

	public GameObject explosionEffect;
	public Rigidbody rb;
	List<string> TagChecks = new List<string> {"Player", "Player_Hitbox"};

	void Awake () {
		rb = GetComponent<Rigidbody> ();
	}

	void OnTriggerEnter (Collider col) {
		if (!TagChecks.Contains(col.gameObject.tag)) {
			Instantiate (explosionEffect, new Vector3 (rb.position.x, rb.position.y, rb.position.z), Quaternion.identity);
			if (col.gameObject.CompareTag ("Enemy")) {
				col.gameObject.GetComponent<EnemyHealth> ().addDamage (10);
			}
			Destroy (this.gameObject);
		}
	}
}
