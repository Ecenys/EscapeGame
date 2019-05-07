using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodScript : MonoBehaviour
{
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
}
