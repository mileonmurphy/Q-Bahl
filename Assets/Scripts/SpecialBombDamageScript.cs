using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpecialBombDamageScript : MonoBehaviour {

	List<GameObject> dmgList;

	// Use this for initialization
	void Start () {
		dmgList = new List<GameObject> ();
		Invoke ("AutoDestroy", 3f);
	}

	void OnTriggerEnter(Collider col){
		
		if (col.gameObject.CompareTag ("Enemy") && !dmgList.Contains(col.gameObject)) {
			dmgList.Add (col.gameObject);
			col.gameObject.GetComponent<EnemyHealth> ().addDamage ((int)Random.Range(50f,100f));
		}

		if (col.gameObject.CompareTag ("IceWall")) {
			col.gameObject.GetComponent<BreakIceWall> ().SetHit ();
		}
	}

	void AutoDestroy(){
		Destroy (this.gameObject);
	}
}
