using UnityEngine;
using System.Collections;

public class splash : MonoBehaviour {
	public float timer=5f;
	public string lvlToLoad;
	// Use this for initialization
	void Start () {
		lvlToLoad="menu";
		StartCoroutine ("MainMenu");
	}
	
	// Update is called once per frame
	void Update () {

	}
	IEnumerator MainMenu(){
		//print ("time: " + timer);
		yield return new WaitForSeconds (timer);
		Application.LoadLevel (lvlToLoad);
	}
}
