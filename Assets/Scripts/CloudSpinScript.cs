using UnityEngine;
using System.Collections;

public class CloudSpinScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		GetComponent<Transform> ().Rotate (new Vector3 (0f, -1f, 0f));
	}
}
