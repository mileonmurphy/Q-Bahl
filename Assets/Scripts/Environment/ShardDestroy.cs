using UnityEngine;
using System.Collections;

public class ShardDestroy : MonoBehaviour {

	bool destroyAllShards;

	GameObject[] shards;

	// Use this for initialization
	void Start () {
		destroyAllShards = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (destroyAllShards) {
			shards = GameObject.FindGameObjectsWithTag ("Shard");
			Invoke ("DestroyShards", 3);
		}

	}

	public void MakeDestroy(){
		destroyAllShards = true;
	}

	void DestroyShards(){
		for (int i = 0; i < shards.Length; i++) {
			Destroy (shards [i]);
		}
		destroyAllShards = false;
	}
}
