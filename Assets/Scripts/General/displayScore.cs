using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayScore : MonoBehaviour {

	// Use this for initialization
	void Update () {
		GetComponent<Text> ().text = " "+(int)GameState.Instance.getDistance()+" m";
	}
}
