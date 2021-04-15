using UnityEngine;
using System.Collections;

public class RedPlayerI_Script : MonoBehaviour {

	public static string redPlayerI_ColName;
	public Vector3 redPlayerI_Pos;
	private int redPlayerI_Steps;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "blocks") 
		{
			redPlayerI_ColName = col.gameObject.name;
			if (col.gameObject.name.Contains("Safe House")) {
				SoundManagerScript.safeHouseAudioSource.Play ();
			}
			if (col.gameObject.name.Contains("Home"))
			{
				SoundManagerScript.safeHouseAudioSource.Play();

				this.transform.position = redPlayerI_Pos;
				RedPlayerI_Script.redPlayerI_ColName = "none";
				redPlayerI_Steps = 0;


			}




		}
	}

	void Start () 
	{
		redPlayerI_ColName = "none";
	}
}
