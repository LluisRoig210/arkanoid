using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	private AudioSource music;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void StartGame(){
		Application.LoadLevel("scene1");
	}
	public void Settings(){
		Application.LoadLevel("settings");
	}
	public void MadeBy(){
		Application.LoadLevel("madeby");
	}
	public void Instructions(){
		Application.LoadLevel ("instructions");
	}
	public void GoBack(){
		Application.LoadLevel ("menu");
	}
}
