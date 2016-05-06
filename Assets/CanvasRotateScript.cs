using UnityEngine;
using System.Collections;

public class CanvasRotateScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.rotation != Quaternion.Euler (0, 0, 0)) {
			Debug.Log ("MEOW");
			transform.rotation = Quaternion.Euler (0, 0, 0);
			Debug.Log (transform.rotation);
		}
	}
}
