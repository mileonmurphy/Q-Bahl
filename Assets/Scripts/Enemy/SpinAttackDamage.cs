using UnityEngine;
using System.Collections;

public class SpinAttackDamage : MonoBehaviour {

	bool spinning;

	// Use this for initialization
	void Start () {
		spinning = transform.parent.parent.GetComponent<GroundEnemyMovement> ().GetSpinning ();
	}
	
	// Update is called once per frame
	void Update () {
		spinning = transform.parent.parent.GetComponent<GroundEnemyMovement> ().GetSpinning ();
	}

	void OnTriggerEnter(Collider col){
		if (spinning) {
			if (col.gameObject.CompareTag ("Player")) {
				col.gameObject.GetComponent<PlayerHealth> ().TakeDamage (1);
			}
		}
	}
}
