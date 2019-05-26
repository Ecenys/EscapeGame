using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class LinternaScript : MonoBehaviour
{
    public GameObject linterna;
	public Transform derecha;

	public GodScript script;
	private bool hecho = false;
	
    void Start()
    {
        linterna.SetActive(false);
    }
	
	void Update()
    {
		if(Vector3.Distance(derecha.position, transform.position) < 0.5){
			linterna.SetActive(true);
            Destroy(this.gameObject);
			if(!hecho){
				script.nextHint();
				hecho = true;
			}
            //transform.position = new Vector3(-100, -100, -100);
        }
	}

}
