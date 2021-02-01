using UnityEngine;
using System.Collections;

public class block_g : MonoBehaviour {
	public float hitsToKill=1f;
	public float hits=0f;
	private float points=10f;

	// Use this for initialization
	void Start () {
		hits = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		//print ("hits:"+hits);
	}

	public void OnCollisionEnter2D(Collision2D hit){
		if (hit.gameObject.tag == "Ball") {
			hits++;
			if(hits==hitsToKill){
				GameObject player=GameObject.FindGameObjectWithTag("Player");
				player.SendMessage("addScore",points);
				Destroy(this.gameObject);
			}
		}
	}
}
