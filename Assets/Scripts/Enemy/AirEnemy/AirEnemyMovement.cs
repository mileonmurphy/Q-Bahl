﻿using UnityEngine;
using System.Collections;

public class AirEnemyMovement : MonoBehaviour {

	float attackSpeed = 10;
	float speed = 5;
	float wanderSpeed = 3;

	GameObject player;
	GameObject[] groundObjs;

	Vector3 startPos;
	Vector3 leftPos;
	Vector3 rightPos;

	bool wandering;
	bool wanderRight;
	bool attacking;

	float attackDist = 5.0f;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		groundObjs = GameObject.FindGameObjectsWithTag ("Ground");
		wandering = true;
		wanderRight = true;
		startPos = transform.position;
		leftPos = Vector3.left * 5;
		leftPos += startPos;
		rightPos = Vector3.right * 5;
		rightPos += startPos;
		attacking = false;
	}

	// Update is called once per frame
	void Update () {
		if ((transform.position - player.transform.position).magnitude < 15.0f) {
			wandering = false;
		} else {
			wandering = true;
		}

		if (wandering) {
			if (wanderRight) {
				transform.rotation = Quaternion.Euler (new Vector3 (0, 180, 0));
				transform.Translate (-wanderSpeed * Time.deltaTime, 0, 0);
				if ((transform.position - rightPos).magnitude < 1.0f) {
					SwitchWander ();
				}
			} else {
				transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));
				transform.Translate (-wanderSpeed * Time.deltaTime, 0, 0);
				if ((transform.position - leftPos).magnitude < 1.0f) {
					SwitchWander ();
				}
			}
		} else {
			if (attacking == false) {
				if (transform.position.x > player.transform.position.x && (transform.position.x - player.transform.position.x) > attackDist) {
					transform.rotation = Quaternion.Euler (new Vector3 (0, 180, 0));
					transform.Translate (speed * Time.deltaTime, 0, 0);
				} else {
					attacking = true;
				}

				if (transform.position.x < player.transform.position.x && (transform.position.x + attackDist) < player.transform.position.x) {
					transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));
					transform.Translate (speed * Time.deltaTime, 0, 0);
				} else {
					attacking = true;
				}
			} else {
				
			}
		}

		for (int i = 0; i < groundObjs.Length; i++) {
			GameObject currGround = groundObjs [i];

			if (transform.position.y > currGround.transform.position.y) {
				if ((transform.position - currGround.transform.position).magnitude < 5.0f) {
					transform.Translate (0, wanderSpeed * Time.deltaTime, 0);
				}
			}
		}

		//zero out the z
		Vector3 tempPos = new Vector3(this.transform.position.x,this.transform.position.y,startPos.z);
		this.transform.position = tempPos;
	}

	void SwitchWander(){
		wanderRight = !wanderRight;
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			Destroy (this.gameObject);
		}
	}

	public void SpeedChange(float num){
		wanderSpeed *= num;
		attackSpeed *= num;
		speed *= num;
	}

	public void ResetNormal(){
		speed = 5f;
		wanderSpeed = 3f;
		attackSpeed = 10f;
	}
}
