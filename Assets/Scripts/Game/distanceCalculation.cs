<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceCalculation : MonoBehaviour {

	private Vector3 lastPosition;
	private float distance;

	// Use this for initialization
	void Start () {
		lastPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (transform.position, lastPosition);
		lastPosition = transform.position;
		if (distance < 10) {
			GameState.Instance.addDistance(distance);
		}
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceCalculation : MonoBehaviour {

	private Vector3 lastPosition;
	private float distance;

	// Use this for initialization
	void Start () {
		lastPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (transform.position, lastPosition);
		lastPosition = transform.position;
		if (distance < 10) {
			GameState.Instance.addDistance(distance);
		}
	}
}
>>>>>>> 137c62aea0078a13b384a7cd1607754cecd63066
