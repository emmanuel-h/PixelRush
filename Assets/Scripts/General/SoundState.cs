using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundState : MonoBehaviour {
	
	public static SoundState Instance;
	public AudioClip jumpSound;

	// Use this for initialization
	void Start () {
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad (Instance.gameObject);
		} else if (this != Instance) {
			Debug.Log ("SoundState Detruit");
			Destroy (this.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {

	}
	/*
	public void touchButtonSound(){
		MakeSound (jumpSound);
	}*/

	public void MakeSound(){
		AudioSource.PlayClipAtPoint (jumpSound, transform.position);
	}
}
