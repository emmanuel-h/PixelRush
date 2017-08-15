<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class GameState : MonoBehaviour {
	
	public static GameState Instance;

	private float distanceTravelled=0f;

	// Use this for initialization
	void Start () {
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad (Instance.gameObject);
		} else if (this != Instance) {
			Debug.Log ("GameState Detruit");
			Destroy (this.gameObject);
		}
	}

	public void addDistance(float distance){
		distanceTravelled += distance;
	}

	public float getDistance(){
		return distanceTravelled;
	}

	public void resetDistance(){
		distanceTravelled = 0f;
	}

	public void death(Collider2D go){
		string name = go.GetComponent<moveEnemy>().GetName();
		int distance = (int)distanceTravelled;
		Analytics.CustomEvent("gameOver", new Dictionary<string,object>{
			{"distance", distance},
			{"enemy", name}
		});
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class GameState : MonoBehaviour {
	
	public static GameState Instance;

	private float distanceTravelled=0f;

	// Use this for initialization
	void Start () {
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad (Instance.gameObject);
		} else if (this != Instance) {
			Debug.Log ("GameState Detruit");
			Destroy (this.gameObject);
		}
	}

	public void addDistance(float distance){
		distanceTravelled += distance;
	}

	public float getDistance(){
		return distanceTravelled;
	}

	public void resetDistance(){
		distanceTravelled = 0f;
	}

	public void death(Collider2D go){
		string name = go.GetComponent<moveEnemy>().GetName();
		int distance = (int)distanceTravelled;
		Analytics.CustomEvent("gameOver", new Dictionary<string,object>{
			{"distance", distance},
			{"enemy", name}
		});
	}
}
>>>>>>> 137c62aea0078a13b384a7cd1607754cecd63066
