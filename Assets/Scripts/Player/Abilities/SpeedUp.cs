using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpeedUp : MonoBehaviour {

	List<GameObject> spedUpObjs;
	bool passes;

	// Use this for initialization
	void Start () {
		passes = true;
		spedUpObjs = new List<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){

		for (int i = 0; i < spedUpObjs.Count; i++) {
			if (spedUpObjs [i] == other.gameObject)
				passes = false;
		}
		if (passes) {
			if (other.CompareTag ("Player")) {
				other.GetComponent<PlayerMovement> ().ChangeSpeed (2);
				spedUpObjs.Add (other.gameObject);
			} else if (other.CompareTag ("Enemy")) {
				if (other.GetComponent<AirEnemyMovement> () != null) {
					other.GetComponent < AirEnemyMovement> ().SpeedChange (2);
					spedUpObjs.Add (other.gameObject);
				}
				if (other.GetComponent<GroundEnemyMovement> () != null) {
					other.GetComponent < GroundEnemyMovement> ().SpeedChange (2);
					spedUpObjs.Add (other.gameObject);
				}
			} else {
				if (other.GetComponent<Rigidbody> () != null) {
					other.GetComponent<Rigidbody> ().velocity *= 2;
				}
			}
		}
	}

	void OnTriggerExit(Collider other){
		if (other.CompareTag ("Player")) {
			other.GetComponent<PlayerMovement> ().ChangeSpeed (0.5f);
			spedUpObjs.Remove (other.gameObject);
		} else if (other.CompareTag ("Enemy")) {
			if (other.GetComponent<AirEnemyMovement> () != null) {
				other.GetComponent < AirEnemyMovement> ().SpeedChange (0.5f);
				spedUpObjs.Remove (other.gameObject);
			}
			if (other.GetComponent<GroundEnemyMovement> () != null) {
				other.GetComponent < GroundEnemyMovement> ().SpeedChange (0.5f);
				spedUpObjs.Remove (other.gameObject);
			}
		} else {
			if (other.GetComponent<Rigidbody> () != null) {
				other.GetComponent<Rigidbody> ().velocity /= 2;
			}
		}
	}
}
