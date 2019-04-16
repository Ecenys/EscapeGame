using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVScript : MonoBehaviour
{
	public GameObject activator;
	
	public GameObject channel1;
	public GameObject channel2;
	public GameObject channel3;
	
	private int channel;
	
    // Start is called before the first frame update
    void Start()
    {
		channel = 1;
		channel1.GetComponent<Renderer>().enabled = false;
		channel2.GetComponent<Renderer>().enabled = false;
		channel3.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
		//pulsar boton
		//modificar channel
		
        if(activator.transform.position.y < -1.0f){
			switch (channel)
			{
			  case 1:
					channel1.GetComponent<Renderer>().enabled = true;
					channel2.GetComponent<Renderer>().enabled = false;
					channel3.GetComponent<Renderer>().enabled = false;
				  break;
			  case 2:
					channel1.GetComponent<Renderer>().enabled = false;
					channel2.GetComponent<Renderer>().enabled = true;
					channel3.GetComponent<Renderer>().enabled = false;
				  break;
			  case 3:
					channel1.GetComponent<Renderer>().enabled = false;
					channel2.GetComponent<Renderer>().enabled = false;
					channel3.GetComponent<Renderer>().enabled = true;
				  break;
			}
			
		}
    }
}
