#pragma warning disable 0219

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateEnemy : MonoBehaviour {

	private GameObject ground;
	private Vector3 highright;
	private float groundsiz;
	private float mysiz;
	private float distanceTravelled;
	private float oldDistance;

	// Use this for initialization
	void Start () {
		highright = Camera.main.ViewportToWorldPoint(new Vector3(1,1,0));
		ground = GameObject.FindGameObjectWithTag ("ground");
		groundsiz = ground.GetComponent<SpriteRenderer>().bounds.size.y;
		oldDistance = 0;
	}
	
	// Update is called once per frame
	void Update () {
		distanceTravelled = GameState.Instance.getDistance ();
		if (distanceTravelled-oldDistance > 5f) {
			oldDistance = distanceTravelled;
			int enemy = Random.Range (1, 8);
			switch (enemy) {
			case 1:
				Single ();
				break;
			case 2:
				Pole ();
				break;
			case 3:
				Stick ();
				break;
			case 4:
				Square ();
				break;
			case 5:
				Stairs ();
				break;
			case 6:
				Hole ();
				break;
			default:
				Diagonal ();
				break;
			}
		}
	}

	void Single (){
		Vector3 tmpPos = new Vector3 (highright.x, ground.transform.position.y + groundsiz, ground.transform.position.z);
		GameObject gY = Instantiate (Resources.Load ("enemy"), tmpPos, Quaternion.identity) as GameObject;
		gY.GetComponent<moveEnemy> ().SetName ("single");
	}

	void Pole (){
		Vector3 tmpPos = new Vector3 (highright.x, ground.transform.position.y + groundsiz, ground.transform.position.z);
		GameObject gY = Instantiate (Resources.Load ("enemy"), tmpPos, Quaternion.identity) as GameObject;
		gY.GetComponent<moveEnemy> ().SetName ("pole");

		Vector3 tmpPos2 = new Vector3 (highright.x, ground.transform.position.y + groundsiz+(gY.GetComponent<SpriteRenderer>().bounds.size.y)*3.5f, ground.transform.position.z);
		GameObject gY2 = Instantiate (Resources.Load ("enemy"), tmpPos2, Quaternion.identity) as GameObject;
		gY2.GetComponent<moveEnemy> ().SetName ("pole");
	}

	void Stick (){
		Vector3 tmpPos = new Vector3 (highright.x, ground.transform.position.y + groundsiz, ground.transform.position.z);
		GameObject gY = Instantiate (Resources.Load ("enemy"), tmpPos, Quaternion.identity) as GameObject;
		gY.GetComponent<moveEnemy> ().SetName ("stick");

		Vector3 tmpPos2 = new Vector3 (highright.x, ground.transform.position.y + groundsiz+gY.GetComponent<SpriteRenderer>().bounds.size.y, ground.transform.position.z);
		GameObject gY2 = Instantiate (Resources.Load ("enemy"), tmpPos2, Quaternion.identity) as GameObject;
		gY2.GetComponent<moveEnemy> ().SetName ("stick");
	}

	void Square (){
		Vector3 posBotLeft = new Vector3 (highright.x, ground.transform.position.y + groundsiz, ground.transform.position.z);
		GameObject goBotLeft = Instantiate (Resources.Load ("enemy"), posBotLeft, Quaternion.identity) as GameObject;
		goBotLeft.GetComponent<moveEnemy> ().SetName ("square");

		Vector3 posHighLeft = new Vector3 (highright.x, ground.transform.position.y + groundsiz+goBotLeft.GetComponent<SpriteRenderer>().bounds.size.y, ground.transform.position.z);
		GameObject goHighLeft = Instantiate (Resources.Load ("enemy"), posHighLeft, Quaternion.identity) as GameObject;
		goHighLeft.GetComponent<moveEnemy> ().SetName ("square");

		Vector3 posBotRight = new Vector3 (highright.x+goBotLeft.GetComponent<SpriteRenderer>().bounds.size.x, ground.transform.position.y + groundsiz, ground.transform.position.z);
		GameObject goBotRight = Instantiate (Resources.Load ("enemy"), posBotRight, Quaternion.identity) as GameObject;
		goBotRight.GetComponent<moveEnemy> ().SetName ("square");

		Vector3 posHighRight = new Vector3 (highright.x+goBotLeft.GetComponent<SpriteRenderer>().bounds.size.x, ground.transform.position.y + groundsiz+goBotLeft.GetComponent<SpriteRenderer>().bounds.size.y, ground.transform.position.z);
		GameObject goHighRight = Instantiate (Resources.Load ("enemy"), posHighRight, Quaternion.identity) as GameObject;
		goHighRight.GetComponent<moveEnemy> ().SetName ("square");
	}

	void Stairs (){
		Vector3 tmpPos = new Vector3 (highright.x, ground.transform.position.y + groundsiz, ground.transform.position.z);
		GameObject gY = Instantiate (Resources.Load ("enemy"), tmpPos, Quaternion.identity) as GameObject;
		gY.GetComponent<moveEnemy> ().SetName ("stairs");

		Vector3 tmpPos2 = new Vector3 (highright.x+gY.GetComponent<SpriteRenderer>().bounds.size.x, ground.transform.position.y + groundsiz, ground.transform.position.z);
		GameObject gY2 = Instantiate (Resources.Load ("enemy"), tmpPos2, Quaternion.identity) as GameObject;
		gY2.GetComponent<moveEnemy> ().SetName ("stairs");

		Vector3 tmpPos3 = new Vector3 (highright.x+gY.GetComponent<SpriteRenderer>().bounds.size.x, ground.transform.position.y+gY.GetComponent<SpriteRenderer>().bounds.size.y + groundsiz, ground.transform.position.z);
		GameObject gY3 = Instantiate (Resources.Load ("enemy"), tmpPos3, Quaternion.identity) as GameObject;
		gY3.GetComponent<moveEnemy> ().SetName ("stairs");
	}

	void Hole (){
		Vector3 tmpPos = new Vector3 (highright.x, ground.transform.position.y + groundsiz, ground.transform.position.z);
		GameObject gY = Instantiate (Resources.Load ("enemy"), tmpPos, Quaternion.identity) as GameObject;
		gY.GetComponent<moveEnemy> ().SetName ("hole");

		Vector3 tmpPos2 = new Vector3 (highright.x+(gY.GetComponent<SpriteRenderer>().bounds.size.x)*2, ground.transform.position.y + groundsiz, ground.transform.position.z);
		GameObject gY2 = Instantiate (Resources.Load ("enemy"), tmpPos2, Quaternion.identity) as GameObject;
		gY2.GetComponent<moveEnemy> ().SetName ("hole");
	}

	void Diagonal (){
		Vector3 tmpPos = new Vector3 (highright.x, ground.transform.position.y + groundsiz, ground.transform.position.z);
		GameObject gY = Instantiate (Resources.Load ("enemy"), tmpPos, Quaternion.identity) as GameObject;
		gY.GetComponent<moveEnemy> ().SetName ("diagonal");

		Vector3 tmpPos2 = new Vector3 (highright.x+(gY.GetComponent<SpriteRenderer>().bounds.size.x)*2, ground.transform.position.y + groundsiz+(gY.GetComponent<SpriteRenderer>().bounds.size.y)*3, ground.transform.position.z);
		GameObject gY2 = Instantiate (Resources.Load ("enemy"), tmpPos2, Quaternion.identity) as GameObject;
		gY2.GetComponent<moveEnemy> ().SetName ("diagonal");
	}
}
