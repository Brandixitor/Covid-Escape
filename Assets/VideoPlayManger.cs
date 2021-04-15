using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayManger : MonoBehaviour {
 
	public VideoClip  p1,p2,p3,p4,p5,p6,p8;
 
	public static VideoPlayer p1source,p2source,p3source,p4source, p5source,p6source,p7source,p8source;
	// Use this for initialization
	VideoPlayer AddVideo(VideoClip clip, bool playOnAwake, bool loop, float  volume)
	{
		VideoPlayer Video= gameObject.AddComponent<VideoPlayer> ();
		Video.clip = clip;
		Video.playOnAwake = playOnAwake;
		Video.isLooping = loop;
//		Video.SetDirectAudioVolume = volume;
		return Video;
	}


	void Start () {
		p1source = AddVideo (p1,false, false, 1.0f);
		p2source = AddVideo (p2,false, false, 1.0f);
		p3source= AddVideo (p3,false, false, 1.0f);
		p4source = AddVideo (p4,false, false, 1.0f);
		p5source = AddVideo (p5,false, false, 1.0f);
		p6source = AddVideo (p6,false, false, 1.0f);
 		p8source = AddVideo (p8,false, false, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
 
}
