using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

	public int maxHealth;
	public GameObject damageParticles;
	public int gooDrop;
	public GameObject drop;

	public AudioClip hitSound;
	public AudioClip deathSound;

	public int currentHealth;

	public Slider enemyHealthIndicator;
	public AudioSource enemyAS;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
<<<<<<< HEAD
		enemyHealthIndicator = GetComponentInChildren<Slider> ();
=======
>>>>>>> 22503ff682935c3f1baf4949039486f2efb9c67a
		enemyHealthIndicator.gameObject.SetActive (false);
		enemyHealthIndicator.maxValue = maxHealth;
		enemyHealthIndicator.value = currentHealth;
		//enemyAS = GetComponent<AudioSource> ();
	}
<<<<<<< HEAD

	// Update is called once per frame
	void Update () {
		this.gameObject.GetComponentInChildren<Canvas>().transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));
		enemyHealthIndicator.transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));
=======
	
	// Update is called once per frame
	void Update () {
		
>>>>>>> 22503ff682935c3f1baf4949039486f2efb9c67a
	}

	public void addDamage(int damage){
		//AudioSource.PlayClipAtPoint (hitSound, transform.position);

		enemyHealthIndicator.gameObject.SetActive (true);
		if (damage <= -1) {
			Debug.Log ("Adding health to enemy Number should be positive");
		}
		currentHealth -= damage;
		enemyHealthIndicator.value = currentHealth;
		if (currentHealth <= 0) {
			MakeDead ();
		}
	}

	void MakeDead(){
		//AudioSource.PlayClipAtPoint (deathSound, transform.position);

		Destroy (this.gameObject);
		for (int i = 0; i < gooDrop; i++) {
			Instantiate (drop, transform.position, transform.rotation);
		}
	}
<<<<<<< HEAD
}
=======
}
>>>>>>> 22503ff682935c3f1baf4949039486f2efb9c67a
