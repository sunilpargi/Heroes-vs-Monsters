using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public float health = 10f;

	public GameObject deadFX;
	public AudioSource deathSound;

	public void TakeDamage(float damageAmount) {
		health -= damageAmount;

		print ("Damage receveid");

		if (health <= 0) {
			deathSound.Play();
			Instantiate (deadFX, transform.position, Quaternion.identity);
			Destroy (gameObject);
		}

	}
		
} // class



































