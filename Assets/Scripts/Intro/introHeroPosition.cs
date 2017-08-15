<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introHeroPosition : MonoBehaviour {

	private Vector3 highleft;

	// Use this for initialization
	void Start () {
		highleft = Camera.main.ViewportToWorldPoint(new Vector3(0,1,0));
		transform.position = new Vector3 (highleft.x/1.5f, -highleft.y/2f, transform.position.z);
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introHeroPosition : MonoBehaviour {

	private Vector3 highleft;

	// Use this for initialization
	void Start () {
		highleft = Camera.main.ViewportToWorldPoint(new Vector3(0,1,0));
		transform.position = new Vector3 (highleft.x/1.5f, -highleft.y/2f, transform.position.z);
	}
}
>>>>>>> 137c62aea0078a13b384a7cd1607754cecd63066
