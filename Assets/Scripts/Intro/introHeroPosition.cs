using System.Collections;
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
