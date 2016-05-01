using UnityEngine;
using System.Collections;

public class BreakIceWall : MonoBehaviour {

	bool hit;

	int numShards;
	int torque = 200;

	public GameObject shard;
	Rigidbody rb;

	GameObject[] shards;

	public GameObject player;

	// Use this for initialization
	void Start () {
		hit = false;
		numShards = 50;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			hit = true;
		}
		if (hit) {
			SpawnShards ();
			DestroyShards ();
			shards = GameObject.FindGameObjectsWithTag ("Shard");
			MoveShards ();
			hit = false;
		}
	}

	public void IsHit(){
		hit = true;
	}

	void SpawnShards(){
		Destroy (this.gameObject);

		for (int i = 0; i < numShards; i++) {
			Instantiate (shard, new Vector3 ((this.transform.position.x), (this.transform.position.y) + Random.Range (-4, 4), (this.transform.transform.position.z) + Random.Range (-3, 3)), new Quaternion (this.transform.rotation.x + Random.Range (0, 360), this.transform.rotation.y + Random.Range (0, 360), this.transform.rotation.z + Random.Range (0, 360), 0));
		}
	}

	void DestroyShards(){
		GameObject.Find ("GameManager").GetComponent<ShardDestroy> ().MakeDestroy ();
	}

	void MoveShards(){
		if (this.transform.position.x > player.transform.position.x) {
			for (int i = 0; i < shards.Length; i++) {
				GameObject curr = shards [i];
				rb = curr.GetComponent<Rigidbody> ();
				rb.AddForce (Vector3.right * (Random.Range (200, 400)));
				rb.AddTorque (Vector3.right * (Random.Range (torque, torque * 2)));
			}
		}

		if (this.transform.position.x < player.transform.position.x) {
			for (int i = 0; i < shards.Length; i++) {
				GameObject curr = shards [i];
				rb = curr.GetComponent<Rigidbody> ();
				rb.AddForce (Vector3.left * (Random.Range (200, 400)));
				rb.AddTorque (Vector3.left * (Random.Range (torque, torque * 2)));
			}
		}
	}
}
