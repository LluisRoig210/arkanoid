using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public float playerSpeed=0f;
	private Vector3 playerPos;
	public float limits;
	private float score;
	private float lifes;
	public bool stop;
	public AudioClip hit;

	// Use this for initialization
	void Start () {
		playerPos = gameObject.transform.position;
		lifes = 3f;
		score = 0f;
		stop = false;
	}
	
	// Update is called once per frame
	void Update () {
		//move the player pos trough the horizontal axis
		playerPos.x += Input.GetAxis ("Horizontal") * playerSpeed;
		transform.position = playerPos;
		//close the app on escape key pressed
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}
		if (Input.GetKeyDown (KeyCode.P)) {
			if(!stop){
				Time.timeScale=0f;
				stop=true;
			}
			else{
				Time.timeScale=1.0f;
				stop=false;
			}
		}
		//set the limits of the area
		if (playerPos.x > limits) {
			transform.position=new Vector3(limits,playerPos.y,playerPos.z);
			playerPos.x = limits;
			//print ("pos player: "+playerPos.x);
			//print (transform.position);
		}

		if (playerPos.x < -limits) {
			transform.position=new Vector3(-limits,playerPos.y,playerPos.z);
			playerPos.x = -limits;
		}
	}
	void addScore(int points){
		score += points;
		//print ("puntos: " + points);
	}
	void OnCollisionEnter(Collision col){
		//play the sound each time on collison.

	}
}
