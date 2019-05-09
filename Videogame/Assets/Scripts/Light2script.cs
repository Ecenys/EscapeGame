using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light2script : MonoBehaviour
{
	public Transform activator;
	
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Light>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(activator.position.y < -1.0f){
			GetComponent<Light>().enabled = true;
		}
    }
}
