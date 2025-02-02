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
        yes.SetActive(false);
        no.SetActive(false);
        sure.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(controller1.transform.position, transform.position) < 0.1f || Vector3.Distance(controller2.transform.position, transform.position) < 0.1f ){
			yes.SetActive(true);
			no.SetActive(true);
			sure.SetActive(true);
		}
    }
}
