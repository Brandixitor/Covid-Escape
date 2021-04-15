using UnityEngine;
using System.Collections;
using UnityEngine.Video;

public class BluePlayerI_Script : MonoBehaviour {

	public static string bluePlayerI_ColName;

 	public Vector3 bluePlayerI_Pos;
	private int bluePlayerI_Steps;
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "blocks") 
		{			
			bluePlayerI_ColName = col.gameObject.name;
			if (col.gameObject.name.Contains("Safe House")) {
				SoundManagerScript.safeHouseAudioSource.Play ();
			}
			if (col.gameObject.name.Contains("Home"))
			{
				SoundManagerScript.safeHouseAudioSource.Play();

				this.transform.position = bluePlayerI_Pos;
				BluePlayerI_Script.bluePlayerI_ColName = "none";
				bluePlayerI_Steps = 0;


			}




		}
	}

	void Start () 
	{
		bluePlayerI_ColName = "none";
	}
}
