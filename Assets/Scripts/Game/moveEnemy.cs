using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveEnemy : MonoBehaviour {

	private Vector2 movement;
	private Vector3 highleft;
	private float mysiz;

	private string whoIAm;

	// Use this for initialization
	void Start () {
		highleft = Camera.main.ViewportToWorldPoint(new Vector3(0,1,0));
		mysiz = GetComponent<SpriteRenderer>().bounds.size.x;
		movement = new Vector2 (-5f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = movement;
		if (transform.position.x < highleft.x-mysiz/2) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "hero") {
			SceneManager.LoadScene ("Loose");
		}
	}

	public void SetName(string name){
		whoIAm = name;
	}

	public string GetName(){
		return whoIAm;
	}
}