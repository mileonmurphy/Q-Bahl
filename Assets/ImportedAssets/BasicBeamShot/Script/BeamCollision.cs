using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BeamCollision : MonoBehaviour {

    public bool Reflect = false;

	private BeamLine BL;

	public GameObject HitEffect = null;

	private BeamParam BP;

	RaycastHit[] hits;


	// Use this for initialization
	void Start () {
		Invoke ("fireLaser", 0.1f);

	}

	public void fireLaser () {
		hits = Physics.RaycastAll (transform.position, transform.forward, 20f);
		foreach (RaycastHit hit in hits) {
			if (hit.transform.CompareTag ("Enemy")) {
				hit.transform.gameObject.GetComponent<EnemyHealth> ().addDamage (25);
			}

			if (hit.transform.gameObject.CompareTag ("IceWall")) {
				hit.transform.gameObject.GetComponent<BreakIceWall> ().SetHit ();
			}
		}
	}
}
