using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introEnemyPosition : MonoBehaviour {
	
	private Vector3 highright;

	// Use this for initialization
	void Start () {
		highright = Camera.main.ViewportToWorldPoint(new Vector3(1,1,0));
		transform.position = new Vector3 (highright.x/1.5f, -highright.y/2f, transform.position.z);
	}
}
