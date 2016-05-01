using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MeleeHitBox : MonoBehaviour {
	public List <GameObject> currentCols = new List <GameObject> ();

	void OnTriggerEnter (Collider col) {
		if (!col.CompareTag ("Player") && !col.CompareTag ("Ground")) {
			currentCols.Add (col.gameObject);
		}
	}

	void OnTriggerExit (Collider col) {
		currentCols.Remove (col.gameObject);

	}

	void Update () {
		if (currentCols.Count > 0) {
			currentCols.RemoveAll ((o) => o == null);
		}
	}
}
