using UnityEngine;
using System.Collections;

public class GroundEnemyMovement : MonoBehaviour {

	float speed = 7;
	float wanderSpeed = 3;

	GameObject player;

	Vector3 startPos;
	Vector3 leftPos;
	Vector3 rightPos;

	bool wandering;
	bool wanderRight;
	bool isSpinning;

	float attackDist = 4.0f;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		wandering = true;
		wanderRight = true;
		isSpinning = false;
		startPos = transform.position;
		leftPos = Vector3.left * 5;
		leftPos += startPos;
		rightPos = Vector3.right * 5;
		rightPos += startPos;
	}
	
	// Update is called once per frame
	void Update () {
        //paused

        if (GameObject.Find("GameManager").GetComponent<GameManager>().GetCurrGameState() != GAME_STATE.START_MENU && GameObject.Find("GameManager").GetComponent<GameManager>().GetCurrGameState() != GAME_STATE.PAUSED && !GameObject.Find("UIManager").GetComponent<UIManager>().GetPaused())
        {
            if ((transform.position - player.transform.position).magnitude < 10)
            {
                wandering = false;
            }
            else
            {
                wandering = true;
            }

            if (wandering)
            {
                if (wanderRight)
                {
                    transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                    transform.Translate(-wanderSpeed * Time.deltaTime, 0, 0);
                    if ((transform.position - rightPos).magnitude < 1.0f)
                    {
                        SwitchWander();
                    }
                }
                else
                {
                    transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                    transform.Translate(-wanderSpeed * Time.deltaTime, 0, 0);
                    if ((transform.position - leftPos).magnitude < 1.0f)
                    {
                        SwitchWander();
                    }
                }
            }
            else
            {

                if (transform.position.x > player.transform.position.x && (transform.position.x - player.transform.position.x) > attackDist)
                {
                    transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                    transform.Translate(speed * Time.deltaTime, 0, 0);
                }
                else if (transform.position.x < player.transform.position.x && (transform.position.x + attackDist) < player.transform.position.x)
                {
                    transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                    transform.Translate(speed * Time.deltaTime, 0, 0);
                }

                if (gameObject.name == "GA1")
                {
                    SpinningAttack();
                    isSpinning = true;
                }
            }
        }
	}

	void SwitchWander(){
		wanderRight = !wanderRight;
	}

	public void SpeedChange(float num){
		wanderSpeed *= num;
		speed *= num;
	}

	public void ResetNormal(){
		speed = 5f;
		wanderSpeed = 3f;
	}

	public void SpinningAttack(){
		transform.FindChild("groundAlien1").transform.Rotate(transform.up, Time.deltaTime* 800f);
	}

	public bool GetSpinning(){
		return isSpinning;
	}
}
