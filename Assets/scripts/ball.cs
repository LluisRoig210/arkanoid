using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	private bool active=false;
	private Vector3 ballPos;
	private Vector3 startPos;
	private Vector2 ballIniForce;
	private Vector2 ballDeforce;
	public static float lifes=3f;
	public GameObject follow;
	//private Vector3 followTranform;

	// Use this for initialization
	void Start () {
		active = false;
		ballIniForce = new Vector2 (100.0f, 300.0f);
		ballDeforce = new Vector2 (50.0f,10.0f);
		ballPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		startPos = new Vector3 (follow.transform.position.x, follow.transform.position.y + 0.7f, follow.transform.position.z);
	
		//print ("tranform pos"+transform.position.y);
		if(transform.position.y<-5.0f){
			lifes--;
			transform.position=startPos;
			active=false;
			GetComponent<Rigidbody2D>().isKinematic = true;
			return;
		}
		/*
		if (transform.position.y.Equals(GameObject.FindGameObjectWithTag("Ball"))) {
			GetComponent<Rigidbody2D>().AddForce(ballDeforce);
		}
		*/
		if (!active) {
			transform.position=startPos;
			if (Input.GetKeyDown (KeyCode.Space)) {
				active = !active;
				GetComponent<Rigidbody2D>().isKinematic = false;
				startMove();
			}
		}
	}
	//function to appply the force to ball
	void startMove(){
		GetComponent<Rigidbody2D>().AddForce(ballIniForce);
	}
}
