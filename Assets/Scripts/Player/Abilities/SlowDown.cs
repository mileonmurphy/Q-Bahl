using UnityEngine;
using System.Collections;

public class SlowDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Player")) {
			other.GetComponent<PlayerMovement> ().ChangeSpeed (0.5f);
		} else if (other.CompareTag ("Enemy")) {
			if (other.GetComponent<AirEnemyMovement> () != null)
				other.GetComponent < AirEnemyMovement> ().SpeedChange (0.5f);
			if (other.GetComponent<GroundEnemyMovement> () != null)
				other.GetComponent < GroundEnemyMovement> ().SpeedChange (0.5f);
		} else {
			if (other.GetComponent<Rigidbody> () != null) {
				other.GetComponent<Rigidbody> ().velocity /= 2;
			}
		}
	}

	void OnTriggerExit(Collider other){
		if (other.CompareTag ("Player")) {
			other.GetComponent<PlayerMovement> ().ChangeSpeed (2);		
		} else if (other.CompareTag ("Enemy")) {
			if (other.GetComponent<AirEnemyMovement> () != null)
				other.GetComponent < AirEnemyMovement> ().SpeedChange (2);
			if (other.GetComponent<GroundEnemyMovement> () != null)
				other.GetComponent < GroundEnemyMovement> ().SpeedChange (2);
		} else {
			if (other.GetComponent<Rigidbody> () != null) {
				other.GetComponent<Rigidbody> ().velocity *= 2;
			}
		}
	}
}
