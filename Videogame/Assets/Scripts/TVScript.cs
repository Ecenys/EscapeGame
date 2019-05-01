using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TVScript : MonoBehaviour
{
	public GameObject activator;
	
	public GameObject channel1;
	public GameObject channel2;
	public GameObject channel3;
	
	public VideoPlayer videoplayer1;
	public VideoPlayer videoplayer2;
	
	public float maxDistanceAudio;
	
	public GameObject player;
	
	public int channel = 1;
	public float volume = 0.4f;
	
    // Start is called before the first frame update
    void Start()
    {
		channel = 1;
		channel1.GetComponent<Renderer>().enabled = false;
		channel2.GetComponent<Renderer>().enabled = false;
		channel3.GetComponent<Renderer>().enabled = false;
		videoplayer1.SetDirectAudioMute(0,true);
		videoplayer2.SetDirectAudioMute(0,true);
    }

    // Update is called once per frame
    void Update()
    {
		float dist = Vector3.Distance(transform.position, player.transform.position);
		float volumencontinuo;
		if  (dist <= maxDistanceAudio)
			volumencontinuo = volume / maxDistanceAudio;
		else
			volumencontinuo=0;
		videoplayer1.SetDirectAudioVolume(0, volumencontinuo);
		videoplayer2.SetDirectAudioVolume(0, volumencontinuo);
		
        if(activator.transform.position.y < -1.0f){
			switch (channel)
			{
			  case 1:
					channel1.GetComponent<Renderer>().enabled = true;
					channel2.GetComponent<Renderer>().enabled = false;
					channel3.GetComponent<Renderer>().enabled = false;
					videoplayer1.SetDirectAudioMute(0,false);
					videoplayer2.SetDirectAudioMute(0,true);
				  break;
			  case 2:
					channel1.GetComponent<Renderer>().enabled = false;
					channel2.GetComponent<Renderer>().enabled = true;
					channel3.GetComponent<Renderer>().enabled = false;
					videoplayer1.SetDirectAudioMute(0,true);
					videoplayer2.SetDirectAudioMute(0,false);
				  break;
			  case 3:
					channel1.GetComponent<Renderer>().enabled = false;
					channel2.GetComponent<Renderer>().enabled = false;
					channel3.GetComponent<Renderer>().enabled = true;
					videoplayer1.SetDirectAudioMute(0,true);
					videoplayer2.SetDirectAudioMute(0,true);
				  break;
			}
			
		}
    }
}
