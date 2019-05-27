using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;
using System;

public class GodScript : MonoBehaviour
{
	// Audios
	public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    public AudioClip audio4;
	public AudioClip audio5;
    public AudioClip audio6;
    public AudioClip audio7;
    public AudioClip audio8;
	public AudioClip audio9;
	public AudioClip audio10;
	
	public AudioClip ea1;
	
	//SteamVR actions
    public SteamVR_Action_Boolean grabPinch;
    public SteamVR_Input_Sources handType;

	//Global parameters
    private float time;
    private int hint;
    private AudioSource audioData;
    private bool press; //evita que el audio se inicie cada frame si lo mantiene pulsado
    
    // Start is called before the first frame update
    void Start()
    {
        //audio = GetComponent<AudioSource>();
        time = 0;
        hint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time < 1) ; //Evitar que despues del inicio se ejecute de manera innecesaria
            quitaGuante();
        if (grabPinch.GetStateDown(handType) && !press){
            sayHint();
            press = true;
        }
        else
            press = false;
    }
    
    //************************** Time **************************//
    public float getTime(){
        return time;
    }
    
    
    //************************** Music **************************//
    //Decir pista
    public void sayHint(){
        GetComponent<AudioSource>().Stop();
        //yield return new WaitForSeconds(audio.clip.length);
        GetComponent<AudioSource>().Play();
    }
    
    //Cambiar pista
    private void changeHint(){
        switch(hint){
			case 0:
				specialAudio(1);
				break;
            case 1:
                GetComponent<AudioSource>().clip = audio1;
                Debug.Log("1");
                break;
            case 2:
                GetComponent<AudioSource>().clip = audio2;
				hint++;
                Debug.Log("2");
                break;
            case 3:
                GetComponent<AudioSource>().clip = audio3;
                Debug.Log("3");
                break;
            case 4:
                GetComponent<AudioSource>().clip = audio4;
                Debug.Log("4");
                break;
			case 5:
                GetComponent<AudioSource>().clip = audio5;
                Debug.Log("5");
                break;
            case 6:
                GetComponent<AudioSource>().clip = audio6;
                Debug.Log("6");
                break;
            case 7:
                GetComponent<AudioSource>().clip = audio7;
                Debug.Log("7");
                break;
            case 8:
                GetComponent<AudioSource>().clip = audio8;
                Debug.Log("8");
                break;
			case 9:
                GetComponent<AudioSource>().clip = audio9;
                Debug.Log("8");
                break;
			case 10:
                GetComponent<AudioSource>().clip = audio10;
                Debug.Log("8");
                break;
        }
    }
    
    public void nextHint() {
        hint++;
		try
		{
			GetComponent<AudioSource>().Stop();
		}catch(Exception e){}
        changeHint();
    }

    public void specialAudio(int i) {
            switch(hint){
            case 1:
                GetComponent<AudioSource>().clip = ea1;
                Debug.Log("1");
				hint = 1;
                break;
            case 2:
				if(hint == 8 || hint == 9)
					hint = 9;
                break;
        }
    }

    //************************** Quitar mando **************************//
    void quitaGuante() {
        for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        {
            Hand hand = Player.instance.hands[handIndex];
            if (hand != null)
            {
                hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithoutController);
            }
        }
        for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        {
            Hand hand = Player.instance.hands[handIndex];
            if (hand != null)
            {
                hand.HideController(true);
            }
        }
    }
}


