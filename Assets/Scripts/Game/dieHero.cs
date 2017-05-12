using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class dieHero : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "enemy") {
			GameState.Instance.death (collider);
			Destroy (gameObject);
		}
	}
}
