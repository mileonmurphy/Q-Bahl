using UnityEngine;
using System.Collections;

public class KamikazeCollisionScript : MonoBehaviour {

	GameObject explodeEffect;

	// Use this for initialization
	void Start () {
		explodeEffect = Resources.Load ("Prefabs/Enemy/KamikazeExplosionEffect") as GameObject;
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.CompareTag ("Player")) {
			Instantiate (explodeEffect, (transform.position + col.transform.position)/2, Quaternion.identity);
			col.gameObject.GetComponent<PlayerHealth> ().TakeDamage (10);
			Destroy (this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
