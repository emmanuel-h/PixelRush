using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGround : MonoBehaviour {

	private Vector3 siz;
	private float positionRestartX;
	private Vector2 movement;
	private Vector3 highleft;
	private Vector3 highright;

	// Use this for initialization
	void Start () {
		highleft = Camera.main.ViewportToWorldPoint(new Vector3(0,1,0));
		highright = Camera.main.ViewportToWorldPoint(new Vector3(1,1,0));
		movement = new Vector2 (-5f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = movement;
		positionRestartX = highright.x+siz.x/2;
		siz.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
		siz.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
		positionRestartX = highright.x+siz.x/2;
		if (transform.position.x < highleft.x - (siz.x / 2)) {
			transform.position = new Vector3 (positionRestartX, transform.position.y, transform.position.z);
		}
	}
}
