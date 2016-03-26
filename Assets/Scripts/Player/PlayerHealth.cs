using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour, IDamageable<int>, IKillable {

	int startingHealth = 100;
	int currentHealth;
	bool isDead;

	PlayerMovement playerMovement;

	void Awake() {
		playerMovement = GetComponent<PlayerMovement> ();
		currentHealth = startingHealth;
		isDead = false;
	}

	public void TakeDamage(int damageTaken) {
        if (!isDead) {
            currentHealth -= damageTaken;
        }
		if (currentHealth <= 0 && !isDead) {
			Death ();
		}
	}

	public void Death() {
		isDead = true;
		Debug.Log ("I AMS DEAD");
		playerMovement.enabled = false;
	}
}
