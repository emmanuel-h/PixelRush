using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBackground : MonoBehaviour {
	private Vector2 speed;
	private float siz;
	private Vector2 movement;
	private Vector3	basgauche;
	private string bg1;
	private string bg2;

	// Use this for initialization
	void Start () {
		bg1 = "background1";
		bg2 = "background2";
		speed = new Vector2(-1f, 0f);
		basgauche = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0));
		movement = new Vector2(speed.x, speed.y);
	}

	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = movement;
		siz = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
		if (transform.position.x < basgauche.x - (siz / 2)) {
			GameObject go;
			if (tag == bg1) {
				Debug.Log ("bg1");
				go = GameObject.FindGameObjectWithTag (bg2);
			} else {
				Debug.Log ("bg2");
				go = GameObject.FindGameObjectWithTag (bg1);
			}
			transform.position = new Vector3 (go.transform.position.x+go.GetComponent<SpriteRenderer>().bounds.size.x, transform.position.y, transform.position.z);
		}
	}
}