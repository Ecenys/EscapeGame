using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVControllerScript : MonoBehaviour
{
	
	public TVScript television;
	
    public void chmas(){
		if (television.channel == 3)
			television.channel = 1;
		else
			television.channel++;
	}
	
	public void chmenos(){
		if (television.channel == 1)
			television.channel = 3;
		else
			television.channel--;
	}
	
	public void vlmas(){
		Debug.Log("Mas Volumen");
	}
	
	public void vlmenos(){
		Debug.Log("Menos Volumen");
	}
}
