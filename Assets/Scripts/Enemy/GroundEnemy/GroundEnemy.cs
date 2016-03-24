using UnityEngine;
using System.Collections;


//Automatically adds a CharacterController component to the same GameObject this script is on
//Reminds developer to not delete the CharController comp. 
[RequireComponent(typeof(Rigidbody))]

abstract public class GroundEnemy : MonoBehaviour {

	//fields
	public int health;
	public int strength;
	public int speed;
	public int gooDrop;

	public int mass;
	public int gravity;

	//used for movement
	protected Vector3 velocity;
	protected Vector3 acceleration;
	protected Vector3 desiredVelocity;

	//internal reference to the CharacterController component
	protected Rigidbody rigid;

	//every child class must implement this method
	abstract protected void CalcSteeringForces();

	//property for velocity
	public Vector3 Velocity {
		get { return velocity; }
		set { velocity = value; }
	}

	// Use this for initialization
	public virtual void Start () {
		mass = 10;
		gravity = 10;
		acceleration = Vector3.zero;
		velocity = transform.forward;
		rigid = gameObject.GetComponent<Rigidbody>();	}
	
	// Update is called once per frame
	protected void Update () {
		CalcSteeringForces();
		
		//update velocity
		velocity += acceleration * Time.deltaTime;
		
		//C# equivalent of Limit
		velocity = Vector3.ClampMagnitude(velocity, speed);
		
		//orient the transform to face where I'm going
		if(velocity != Vector3.zero){
			transform.forward = velocity.normalized;
		}
		
		//CharacterController will do the moving for us
		rigid.MovePosition(transform.position + velocity * Time.deltaTime);

		//zero out the acceleration
		acceleration = Vector3.zero;
	}


	protected void ApplyForce(Vector3 steeringForce) {
		acceleration += steeringForce / mass;
	}
	
	//FUNCTIONS THAT RETURN STEERING FORCES
	protected Vector3 Seek(Vector3 targetPos) {
		//find desired velocity
		desiredVelocity = targetPos - transform.position;
		//scale the desired by max speed
		desiredVelocity = desiredVelocity.normalized * speed;
		//desiredVelocity subtract current velocity
		desiredVelocity -= velocity;
		return desiredVelocity;
	}
	
	protected Vector3 Flee(Vector3 targetPos) {
		//find desired velocity
		desiredVelocity = targetPos - transform.position;
		//scale the desired by max speed
		desiredVelocity = desiredVelocity.normalized * speed;
		//desiredVelocity subtract current velocity
		desiredVelocity -= velocity;
		
		return desiredVelocity * -1;
	}


	//handles flocking - makes sure models keep distance from eachother
	public Vector3 Separation(GameObject[] flockers, float separationDistance) {
		Vector3 total = Vector3.zero;
		
		//go through all the flockers
		foreach(GameObject f in flockers){
			Vector3 dv = transform.position - f.transform.position;
			float dist = dv.magnitude;
			if(dist < separationDistance){
				dv *= separationDistance / dist;
				dv.y = 0;
				total += dv;
			}
		}
		
		total = total.normalized * speed;
		total -= velocity;
		return total;
	}
	
	public Vector3 Alignment(Vector3 alignVector) {
		Vector3 dv = alignVector.normalized * speed;
		dv -= velocity;
		dv.y = 0;
		return dv;
	}
	
	public Vector3 Cohesion(Vector3 cohesionVector) {
		return Seek(cohesionVector);
	}
	
	public Vector3 Arrive(Vector3 target){
		Vector3 target_offset = target - transform.position;
		float distance = target_offset.magnitude;
		float ramped_speed = speed * (distance / 10);
		Vector3 desired_velocity = (Mathf.Floor(ramped_speed) / distance) * target_offset;
		Vector3 steering = desired_velocity - velocity;
		return steering;
	}

	public Vector3 Wander(){
		int rad = 20;
		Vector3 vel = Vector3.ClampMagnitude (transform.forward, rad);
		return Seek (vel);
	}

	public void TurnAround(){
		transform.Rotate (0,180,0);
	}

	public void TakeDamage(int num){
		health -= num;
	}

	public int DealDamage(){
		return strength;
	}

	public float Remap (float value, float from1, float to1, float from2, float to2) {
		return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
	}
}
