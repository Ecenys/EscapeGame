﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public GameObject controller1;
	public GameObject controller2;
	
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(controller1.transform.position, transform.position) < 0.1f || Vector3.Distance(controller2.transform.position, transform.position) < 0.1f )
			//acciones extra (movimiento npc)
			Application.LoadLevel("Amazing videogame");
            //acciones extra (movimiento npc)
        if (Input.GetKeyDown( KeyCode.D ))
			Application.LoadLevel("Amazing videogame");
    }

}
