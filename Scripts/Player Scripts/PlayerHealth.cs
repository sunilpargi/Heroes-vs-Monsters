using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public float health = 100f;

	public GameObject deadFX;
	public Text playerHealthText;
	public AudioSource audioSource;
	public AudioClip dieClip, hurtClip;

    private void Start()
    {
		playerHealthText = GameObject.FindGameObjectWithTag("Health").GetComponent<Text>();
		playerHealthText.text = health.ToString();
    }
    public void TakeDamage(float damageAmount) {
		health -= damageAmount;
		playerHealthText.text = health.ToString();
		audioSource.PlayOneShot(hurtClip);
		print ("received DAMAGE");

		if (health <= 0) {
			audioSource.PlayOneShot(dieClip);
			Instantiate (deadFX, transform.position, Quaternion.identity);
			Destroy (gameObject);
		}
	}

} // class






































