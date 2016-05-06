using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RangedBombAbility : MonoBehaviour {
	List<string> TagChecks = new List<string> {"Player", "Player_Hitbox"};
	GameObject AOECol;
	GameObject bombPE;
	GameObject bombMistPE;

	// Use this for initialization
	void Start () {
		AOECol = Resources.Load ("Prefabs/Abilities/RangedSpecialDamageCollider") as GameObject;
		bombPE = Resources.Load ("Prefabs/Abilities/ParticleEffects/SpecialBombEffect") as GameObject;
		bombMistPE = Resources.Load ("Prefabs/Abilities/ParticleEffects/BombMist") as GameObject;
	}

	void OnTriggerEnter (Collider col) {
		if (!TagChecks.Contains (col.gameObject.tag)) {
			Instantiate (AOECol, transform.position, Quaternion.identity);
			Instantiate (bombPE, transform.position, transform.rotation);
			Instantiate (bombMistPE, transform.position, transform.rotation);
			Destroy (this.gameObject);
		}
	}



	// Update is called once per frame
	void Update () {

	}
}
