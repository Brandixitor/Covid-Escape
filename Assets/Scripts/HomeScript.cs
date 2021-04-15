using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class HomeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Play()
	{
		SceneManager.LoadScene ("Main Menu");
	}


	public void Setting()
	{
		SceneManager.LoadScene ("Setting");
	}

	public void quit()
	{
		SoundManagerScript.buttonAudioSource.Play ();
		Application.Quit ();
	}
}
