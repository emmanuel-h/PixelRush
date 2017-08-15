<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAgain : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			Touch p = Input.GetTouch (0);
			if (p.phase == TouchPhase.Began) {
				GameState.Instance.resetDistance ();
				SceneManager.LoadScene ("Game");
			}
		}
		bool sp = Input.GetKeyDown (KeyCode.Space);
		if (sp) {
			GameState.Instance.resetDistance ();
			SceneManager.LoadScene ("Game");
		}
		if (Input.GetKey("escape")) {
			Application.Quit();
		}
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAgain : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			Touch p = Input.GetTouch (0);
			if (p.phase == TouchPhase.Began) {
				GameState.Instance.resetDistance ();
				SceneManager.LoadScene ("Game");
			}
		}
		bool sp = Input.GetKeyDown (KeyCode.Space);
		if (sp) {
			GameState.Instance.resetDistance ();
			SceneManager.LoadScene ("Game");
		}
		if (Input.GetKey("escape")) {
			Application.Quit();
		}
	}
}
>>>>>>> 137c62aea0078a13b384a7cd1607754cecd63066
