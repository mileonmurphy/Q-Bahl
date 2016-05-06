using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LaserBulletScript : MonoBehaviour {

	List<string> TagChecks = new List<string> {"Player", "Player_Hitbox"};
	GameObject laserBulletPE;

	void Start () {
		Invoke ("destroySelf", 3);
		laserBulletPE = Resources.Load ("Prefabs/Abilities/ParticleEffects/LaserBulletHitEffect") as GameObject;
	}

	void OnTriggerEnter (Collider col) {
		if (!TagChecks.Contains (col.gameObject.tag)) {
			if (col.CompareTag ("Enemy")) {
				col.gameObject.GetComponent<EnemyHealth> ().addDamage (Random.Range (1, 3));
			}
			Destroy (this.gameObject);
			Instantiate (laserBulletPE, transform.position, transform.rotation);
		}
	}

	void destroySelf () {
		Destroy (this.gameObject);
	}

}
