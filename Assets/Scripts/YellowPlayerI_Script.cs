using UnityEngine;
using System.Collections;

public class YellowPlayerI_Script : MonoBehaviour {
 	public Vector3 yellowPlayerI_Pos;
	private int yellowPlayerI_Steps;
	public static string yellowPlayerI_ColName;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "blocks") 
		{
			yellowPlayerI_ColName = col.gameObject.name;
			if (col.gameObject.name.Contains("Safe House")) {
				SoundManagerScript.safeHouseAudioSource.Play ();
			}
			if (col.gameObject.name.Contains("Home"))
			{
				SoundManagerScript.safeHouseAudioSource.Play();

				this.transform.position = yellowPlayerI_Pos;
				YellowPlayerI_Script.yellowPlayerI_ColName = "none";
				yellowPlayerI_Steps = 0;


			}

		}
	}

	void Start () 
	{
		yellowPlayerI_ColName = "none";
	}
}
