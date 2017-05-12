using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayHighscore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = " BEST : \n "+PlayerPrefs.GetInt ("pixelrush")+" m ";
	}
}
