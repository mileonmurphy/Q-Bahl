using UnityEngine;
using System.Collections;

public class PlayerElementalForm : PlayerTransform {
	
	void Awake () {
		transform_name = "Elemental";
		transform_description = "Avatar yo.";
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
