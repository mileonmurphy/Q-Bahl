using UnityEngine;
using System.Collections;

public class PlayerRangedForm : PlayerTransform {
	
	void Awake () {
		transform_name = "Ranged";
		transform_description = "I'm over here.";
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
