﻿using UnityEngine;
using System.Collections.Generic;

public class PlayerTransformManager : MonoBehaviour {

	// Holds the player's transformation forms
	public Dictionary<int, PlayerTransform> transform_dict;

	PlayerTransform current_form;

	// Use this for initialization
	void Awake () {
		transform_dict = new Dictionary<int, PlayerTransform> ();
		transform_dict.Add (1, GetComponent<PlayerNormalForm> ());
		transform_dict.Add (2, GetComponent<PlayerWarpForm> ());
		transform_dict.Add (3, GetComponent<PlayerRangedForm> ());
		transform_dict.Add (4, GetComponent<PlayerElementalForm> ());
		ChangePlayerForm (1);
	}

	void Update () {
		CheckForTransform ();
		UseAbility ();
	}

	void CheckForTransform () {
		if (Input.GetKeyDown(KeyCode.Alpha1) && current_form != transform_dict[1]) {
			ChangePlayerForm(1);
		}
		if (Input.GetKeyDown(KeyCode.Alpha2) && current_form != transform_dict[2]) {
			ChangePlayerForm (2);
		}
		if (Input.GetKeyDown(KeyCode.Alpha3) && current_form != transform_dict[3]) {
			ChangePlayerForm (3);
		}
		if (Input.GetKeyDown(KeyCode.Alpha4) && current_form != transform_dict[4]) {
			ChangePlayerForm (4);
		}
	}

	void ChangePlayerForm (int form_num) {
		current_form = transform_dict[form_num];
		Debug.Log ("Transforming into " + current_form.transform_name + " form!");
	}

	public PlayerTransform GetCurrentForm () {
		return current_form;
	}

	void UseAbility () {
		if (current_form != null) {
			if (Input.GetMouseButtonDown(0)) {
				UseAbility1 ();
			} else if (Input.GetMouseButtonDown(1)) {
				UseAbility2 ();
			} else if (Input.GetKeyDown(KeyCode.E)) {
				UseSpecialAbility ();
			}
			;
		} else {

		}
	}

	void UseAbility1 () {
		current_form.Ability1 ();
	}

	void UseAbility2 () {
		current_form.Ability2 ();
	}

	void UseSpecialAbility () {
		current_form.SpecialAbility ();
	}
}
