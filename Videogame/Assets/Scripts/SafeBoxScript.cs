using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SafeBoxScript : MonoBehaviour
{
	public GameObject key1;
	public GameObject key2;
	public GameObject key3;
	public GameObject key4;
	public GameObject key5;
	public GameObject key6;
	
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Interactable>().enabled = false;
		GetComponent<Throwable>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
		// Debug.Log(key1.GetComponent<LinearMapping>().value);
		// Debug.Log(key2.GetComponent<LinearMapping>().value);
		// Debug.Log(key3.GetComponent<LinearMapping>().value);
		// Debug.Log(key4.GetComponent<LinearMapping>().value);
		// Debug.Log(key5.GetComponent<LinearMapping>().value);
		// Debug.Log(key6.GetComponent<LinearMapping>().value);

        if (0.7f<key1.GetComponent<LinearMapping>().value || key1.GetComponent<LinearMapping>().value<0.8 || 0.6<key2.GetComponent<LinearMapping>().value || key2.GetComponent<LinearMapping>().value<0.7 || 0.9<key3.GetComponent<LinearMapping>().value || key3.GetComponent<LinearMapping>().value<1 || 0.2<key4.GetComponent<LinearMapping>().value || key4.GetComponent<LinearMapping>().value<0.3 || 0.8<key5.GetComponent<LinearMapping>().value || key5.GetComponent<LinearMapping>().value<0.9 || 0.7<key6.GetComponent<LinearMapping>().value || key6.GetComponent<LinearMapping>().value<0.8){
			GetComponent<Interactable>().enabled = true;
			GetComponent<Throwable>().enabled = true;
            Debug.Log("Esta bien");

		}
    }
}

/**
0.7<x<0.8	0	1	3
0.8<x<0.9	1	3
0.9<x<1		2	2
0<x<0.1		3
0.1<x<0.2	4
0.2<x<0.3	5	2
0.3<x<0.4	6
0.4<x<0.5	7
0.5<x<0.6	8
0.6<x<0.7	9	1

09:25:10
**/
