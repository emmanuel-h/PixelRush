<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class launchGame : MonoBehaviour {

	void Awake(){
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = 60;
	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			Touch p = Input.GetTouch (0);
			if (p.phase == TouchPhase.Began) {
				SceneManager.LoadScene ("Game");
				Destroy(GetComponent<launchGame>());
			}
		}
		bool sp = Input.GetKeyDown (KeyCode.Space);
		if (sp) {
			SceneManager.LoadScene ("Game");
			Destroy(GetComponent<launchGame>());
		}
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class launchGame : MonoBehaviour {

	void Awake(){
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = 60;
	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			Touch p = Input.GetTouch (0);
			if (p.phase == TouchPhase.Began) {
				SceneManager.LoadScene ("Game");
				Destroy(GetComponent<launchGame>());
			}
		}
		bool sp = Input.GetKeyDown (KeyCode.Space);
		if (sp) {
			SceneManager.LoadScene ("Game");
			Destroy(GetComponent<launchGame>());
		}
	}
}
>>>>>>> 137c62aea0078a13b384a7cd1607754cecd63066
