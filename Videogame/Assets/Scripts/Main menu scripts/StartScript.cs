using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public GameObject controller1;
	public GameObject controller2;
	
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(controller1.transform.position, transform.position) < 1 || Vector3.Distance(controller2.transform.position, transform.position) < 1 )
			//acciones extra (movimiento npc)
			Application.LoadLevel("Amazing videogame");
    }
}
