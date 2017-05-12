using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveHighscore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int highscore = PlayerPrefs.GetInt ("pixelrush");
		int newscore = (int)(GameState.Instance.getDistance ());
		if (newscore > highscore) {
			PlayerPrefs.SetInt ("pixelrush", newscore);
		}
	}
}
