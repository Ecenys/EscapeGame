using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class GodScript : MonoBehaviour
{
    public SteamVR_Action_Boolean grabPinch;
    public SteamVR_Input_Sources handType;

	private float time;
	private int hint; 
	
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time < 5) ;
            quitaGuante();
        if (grabPinch.GetStateDown(handType))
            getHint();
    }
	
	public float getTime(){
		return time;
	}
	
	public void getHint(){
		switch(hint){
			case 1:
				Debug.Log("1");
				break;
			case 2:
				Debug.Log("2");
				break;
			case 3:
				Debug.Log("3");
				break;
			case 4:
				Debug.Log("4");
				break;
		}
	}

    public void nextHint() {
        hint++;
    }

    public void specialAudio(int i) {
            
    }

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
