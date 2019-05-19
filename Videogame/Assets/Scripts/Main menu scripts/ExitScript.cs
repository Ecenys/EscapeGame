﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
	public GameObject controller1, controller2;
	public GameObject yes, no, sure;
	
    // Start is called before the first frame update
    void Start()
    {
        yes.GetComponent<Renderer>().enabled = false;
		no.GetComponent<Renderer>().enabled = false;
		sure.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(controller1.transform.position, transform.position) < 1 || Vector3.Distance(controller2.transform.position, transform.position) < 1 ){
			yes.GetComponent<Renderer>().enabled = true;
			no.GetComponent<Renderer>().enabled = true;;
			sure.GetComponent<Renderer>().enabled = true;
		}
    }
}
