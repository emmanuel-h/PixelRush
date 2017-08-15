<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayScore : MonoBehaviour {

	// Use this for initialization
	void Update () {
		GetComponent<Text> ().text = " "+(int)GameState.Instance.getDistance()+" m";
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayScore : MonoBehaviour {

	// Use this for initialization
	void Update () {
		GetComponent<Text> ().text = " "+(int)GameState.Instance.getDistance()+" m";
	}
}
>>>>>>> 137c62aea0078a13b384a7cd1607754cecd63066
