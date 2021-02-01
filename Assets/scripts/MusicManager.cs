using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	private static MusicManager _instance;	
	void Awake()
	{
		
		if (_instance)
			DestroyImmediate (gameObject);
		else {
			DontDestroyOnLoad (gameObject);
			_instance = this;
			
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
