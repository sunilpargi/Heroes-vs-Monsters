using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour {

	// Use this for initialization
	public AudioSource uiTouchSound;
	void Start () {
		
	}
	
	public void LoadOtherWorld() {
		uiTouchSound.Play();
		string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
		SceneLoader.instance.LoadLevel (name);
	}

} // class
