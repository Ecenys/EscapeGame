using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesScript : MonoBehaviour
{
	public GameObject controller1, controller2;
	public GameObject no, sure;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(controller1.transform.position, transform.position) < 0.1f || Vector3.Distance(controller2.transform.position, transform.position) < 0.1f ){
			//Acciones npc
			Application.Quit();
		}
    }
}
