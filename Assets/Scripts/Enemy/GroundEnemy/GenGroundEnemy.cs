using UnityEngine;
using System.Collections;

public class GenGroundEnemy : GroundEnemy {

	//need to mess around with numbers
	//weights for steering forces
	public float seekWt = 200.0f;
	public float avoidWt = 350.0f;
	public float avoidDist = 40.0f;
	public float fleeWt = 100.0f;
	public float wanderWt = 20.0f;
	//flocking weights
	public float separationWt = 150f;
	public float separationDist = 25f;
	public float cohesionWt = 10f;
	public float alignmentWt = 10f;
	public float boundsWt = 350f;

	public int maxForce = 20;

	public bool wandering;

	public float wanderTime;

	// Use this for initialization
	override public void Start () {
		base.Start();
		speed = 30;
		strength = 10;
		health = 100;
		gooDrop = 10;
		wanderTime = 5.0f;
		wandering = true;
	}
	
	// Update is called once per frame
	protected override void CalcSteeringForces() {
		//get a force vector
		Vector3 force = Vector3.zero;
		
		Vector3 vel = Vector3.ClampMagnitude (velocity, 20);

		if(wandering){
			force += Wander (); 

			if(Time.time >= wanderTime){
				TurnAround();
				wanderTime += wanderTime;
			}
		}

		//limit Force and apply
		force = Vector3.ClampMagnitude(force, maxForce);
		ApplyForce(force); 
	}
}
