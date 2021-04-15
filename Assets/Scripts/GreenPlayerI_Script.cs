using UnityEngine;
using System.Collections;

public class GreenPlayerI_Script : MonoBehaviour {

	public static string greenPlayerI_ColName;
	public Vector3 greenPlayerI_Pos;
	private int greenPlayerI_Steps;
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "blocks") 
		{
			greenPlayerI_ColName = col.gameObject.name;
			if (col.gameObject.name.Contains("Safe House")) {
				SoundManagerScript.safeHouseAudioSource.Play ();
			}
			if (col.gameObject.name.Contains("Home"))
			{
				SoundManagerScript.safeHouseAudioSource.Play();

				this.transform.position = greenPlayerI_Pos;
				GreenPlayerI_Script.greenPlayerI_ColName = "none";
				greenPlayerI_Steps = 0;


			}





		}
	}

	void Start () 
	{
		greenPlayerI_ColName = "none";
	}
}
