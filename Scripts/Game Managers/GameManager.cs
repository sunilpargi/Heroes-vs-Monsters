using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	[SerializeField]
	private GameObject[] characters;

	[HideInInspector]
	public int selectedCharacterIndex;

	public GameObject playerInventory;

	public static bool sceneloadedFromMainmenu;
	Vector3 pos;
	void Awake () {
		MakeSingleton ();
	}

	void OnEnable() {
		SceneManager.sceneLoaded += LevelFinishedLoading;
	}

	void OnDisable() {
		SceneManager.sceneLoaded -= LevelFinishedLoading;
	}
	
	void MakeSingleton() {
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	void LevelFinishedLoading(Scene scene, LoadSceneMode mode) {
		if (scene.name != "MainMenu") {

			Instantiate (playerInventory, Vector3.zero, Quaternion.identity);

            if (!sceneloadedFromMainmenu)
            {
				 pos = GameObject.FindGameObjectWithTag ("SpawnPosition1").transform.position;
				sceneloadedFromMainmenu = true;

            }
            else
            {
				 pos = GameObject.FindGameObjectWithTag("SpawnPosition").transform.position;
			}
			Instantiate (characters[selectedCharacterIndex], pos, Quaternion.identity);
		}
	}

	

} // class












































