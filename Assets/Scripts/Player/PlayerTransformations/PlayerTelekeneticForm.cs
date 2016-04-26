using UnityEngine;
using System.Collections;

public class PlayerTelekeneticForm : PlayerTransform {
	
	void Awake () {
		transform_name = "Telekenetic";
		transform_description = "These are not the droids you are looking for.";
	}
	
	public override void Ability1() {
		Debug.Log ("Normal Ability 1");
	}
	
	public override void Ability2() {
		Debug.Log ("Normal Ability 2");
	}
	
	public override void SpecialAbility() {
		Debug.Log ("Normal Special Ability");
	}
}
