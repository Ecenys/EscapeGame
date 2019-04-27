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
		if (television.volume == 1)
			television.volume = 1;
		else
			television.volume += 0.2f;
	}
	public void vlmenos(){
		if (television.volume == 0)
			television.volume = 0;
		else
			television.volume -= 0.2f;
	}
}
