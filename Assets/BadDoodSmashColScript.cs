using UnityEngine;
using System.Collections;

public class BadDoodSmashColScript : MonoBehaviour {

	bool hit;
	MasterHandScript.BossState currState;

	void Start () {
		hit = false;
		currState = transform.parent.GetComponent<MasterHandScript> ().getCurrState ();
	}

	void OnTriggerEnter (Collider col) {
		currState = transform.parent.GetComponent<MasterHandScript> ().getCurrState ();
		if (col.gameObject.CompareTag ("Player") && currState == MasterHandScript.BossState.SMASH) {
			col.gameObject.GetComponent<PlayerHealth> ().TakeDamage (15);
			col.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (0f, -100f, 0));
			hit = true;
			Invoke ("resetHit", 5);
		}
	}

	void resetHit () {
		hit = false;
	}
}
