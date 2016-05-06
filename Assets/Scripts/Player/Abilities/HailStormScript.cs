using UnityEngine;
using System.Collections;

public class HailStormScript : MonoBehaviour {
	Transform trans;
	GameObject hailObj;
	ParticleSystem thunderEffect;
	GameObject lightningSpark;
	MeshRenderer rend;
	Vector3 originalSize;
	Transform stormCloud;
	Transform lightningCloud;
	StormState currState;
	float xDim;
	float yDIm;
	float zDim;
	float randX;
	float randY;
	float randZ;

	void Start () {
		trans = GetComponent<Transform> ();
		rend = GetComponent<MeshRenderer> ();
		hailObj = Resources.Load ("Prefabs/Abilities/Damaging Hail") as GameObject;
		stormCloud = transform.FindChild ("Storm Cloud");
		lightningCloud = transform.FindChild ("Lightning Cloud");
		thunderEffect = transform.FindChild ("Thunder").gameObject.GetComponent<ParticleSystem> ();
		lightningSpark = Resources.Load ("Prefabs/Abilities/ParticleEffects/Lightning Spark") as GameObject;
		originalSize = trans.localScale;
		trans.localScale = originalSize * 0.05f;
		currState = StormState.GROWING;
		xDim = rend.bounds.size.x / 2.0f;
		yDIm = rend.bounds.size.y / 2.0f;
		zDim = rend.bounds.size.z / 2.0f;

//		Instantiate (lightningSpark, trans.position, Quaternion.identity);
		InvokeRepeating ("spawnHail", 1, 0.4f);
		Invoke ("despawnStorm", 8);
	}

	void Update () {
		// Spin dem clouds
		rotateClouds ();

		switch (currState) {
		case StormState.GROWING:
			growStorm ();
			break;
		case StormState.SHRINKING:
			shrinkStorm ();
			break;
		}
		xDim = rend.bounds.size.x / 2.0f;
		yDIm = rend.bounds.size.y / 2.0f;
		zDim = rend.bounds.size.z / 2.0f;
	}

	void rotateClouds () {
		stormCloud.Rotate (new Vector3 (0f, 3f / (trans.localScale.x / originalSize.x), 0f));
		lightningCloud.Rotate (new Vector3 (0f, -0.5f / (trans.localScale.x / originalSize.x), 0f));
	}

	void spawnHail () {
		for (int i = 0; i < 10; i++) {
			randX = Random.Range (xDim * -0.80f, xDim * 0.80f);
			randY = Random.Range (yDIm * -0.80f, yDIm * 0.80f);
			randZ = Random.Range (zDim * -0.50f, zDim * 0.50f);
			Instantiate (hailObj, new Vector3 (trans.position.x + randX, trans.position.y + randY, trans.position.z + randZ), Quaternion.Euler (5, 0, 5));
		}
	}

	void stopHail () {
		CancelInvoke ("spawnHail");
	}

	void despawnStorm () {
		stopHail ();
		thunderEffect.Stop ();
		currState = StormState.SHRINKING;
	}

	void growStorm () {
		trans.localScale = new Vector3 (trans.localScale.x * 1.06f, trans.localScale.y * 1.06f, trans.localScale.z * 1.06f);
		if (trans.localScale.x >= originalSize.x) {
			currState = StormState.IDLE;
			thunderEffect.Play ();
		}
	}

	void shrinkStorm () {
		if (thunderEffect.isStopped) {
			if (trans.localScale.x <= originalSize.x * 0.05f) {
				Instantiate (lightningSpark, trans.position, Quaternion.identity);
				Destroy (this.gameObject);
			} else {
				trans.localScale = new Vector3 (trans.localScale.x * 0.94f, trans.localScale.y * 0.94f, trans.localScale.z * 0.94f);
			}
		}
	}

	enum StormState {
		GROWING,
		IDLE,
		SHRINKING
	}

}
