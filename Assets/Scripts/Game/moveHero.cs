<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHero : MonoBehaviour {

	private bool onGround;
	private float maxJumpTime;
	private float jumpTime;
	private float groundsiz;
	private GameObject ground;
	float deltaTime;
	float fps;

	void Start () {
		jumpTime = 0f;
		deltaTime = 0f;
		maxJumpTime = 0.5f;
		onGround = true;
		ground = GameObject.FindGameObjectWithTag ("ground");
		groundsiz = ground.GetComponent<SpriteRenderer>().bounds.size.y;
		Reset ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			Touch p = Input.GetTouch (0);
			if (p.phase == TouchPhase.Began && onGround) {
				Jump ();
			}
			if ((p.phase == TouchPhase.Stationary || p.phase == TouchPhase.Moved) && !onGround) {
				JumpHigher ();
			}
		}
		bool sp = Input.GetKeyDown (KeyCode.Space);
		
		if (sp && onGround) {
			Jump ();
		}
		sp = Input.GetKey (KeyCode.Space);
		if (sp && !onGround) {
			JumpHigher ();
		}
	}
		
	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "ground") {
			Reset ();
		}
	}

	void Jump(){
		GetComponent<Rigidbody2D> ().gravityScale = 3;
		onGround = false;
		GetComponent<Rigidbody2D> ().velocity=new Vector2(0f,8f);
		SoundState.Instance.MakeSound ();
	}

	void JumpHigher(){
		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
		fps = 1.0f / deltaTime;
		jumpTime += Time.deltaTime;
		if (jumpTime < maxJumpTime) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0f, 25f/fps);
		}
	}

	void Reset(){
		transform.position = new Vector3 (transform.position.x, ground.transform.position.y + groundsiz, transform.position.z);
		jumpTime = 0f;
		onGround = true;
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 0f);
		GetComponent<Rigidbody2D> ().gravityScale = 0;
		deltaTime = 0f;
	}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHero : MonoBehaviour {

	private bool onGround;
	private float maxJumpTime;
	private float jumpTime;
	private float groundsiz;
	private GameObject ground;
	float deltaTime;
	float fps;

	void Start () {
		jumpTime = 0f;
		deltaTime = 0f;
		maxJumpTime = 0.5f;
		onGround = true;
		ground = GameObject.FindGameObjectWithTag ("ground");
		groundsiz = ground.GetComponent<SpriteRenderer>().bounds.size.y;
		Reset ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			Touch p = Input.GetTouch (0);
			if (p.phase == TouchPhase.Began && onGround) {
				Jump ();
			}
			if ((p.phase == TouchPhase.Stationary || p.phase == TouchPhase.Moved) && !onGround) {
				JumpHigher ();
			}
		}
		bool sp = Input.GetKeyDown (KeyCode.Space);
		
		if (sp && onGround) {
			Jump ();
		}
		sp = Input.GetKey (KeyCode.Space);
		if (sp && !onGround) {
			JumpHigher ();
		}
	}
		
	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "ground") {
			Reset ();
		}
	}

	void Jump(){
		GetComponent<Rigidbody2D> ().gravityScale = 3;
		onGround = false;
		GetComponent<Rigidbody2D> ().velocity=new Vector2(0f,8f);
		SoundState.Instance.MakeSound ();
	}

	void JumpHigher(){
		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
		fps = 1.0f / deltaTime;
		jumpTime += Time.deltaTime;
		if (jumpTime < maxJumpTime) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0f, 25f/fps);
		}
	}

	void Reset(){
		transform.position = new Vector3 (transform.position.x, ground.transform.position.y + groundsiz, transform.position.z);
		jumpTime = 0f;
		onGround = true;
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 0f);
		GetComponent<Rigidbody2D> ().gravityScale = 0;
		deltaTime = 0f;
	}
>>>>>>> 137c62aea0078a13b384a7cd1607754cecd63066
}