using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
	
	public bool tocado;
	private Quaternion rot;

    // Start is called before the first frame update
    void Start()
    {
		GetComponent<BoxCollider>().enabled = false;
		tocado = false;
    }

    // Update is called once per frame
    void Update()
    {
         if(tocado){
			GetComponent<BoxCollider>().enabled = true;
		 }
    }
	
}
