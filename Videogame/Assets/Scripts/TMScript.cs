﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class TMScript : MonoBehaviour
{
	public GameObject activate;
	public GameObject door;
    public Transform player;
    public GameObject pared;
    public GameObject tp1;
    public GameObject tp2;
	
	public GodScript script;
	private bool hecho = false;
	
	private bool puzzle;
    private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
		door.GetComponent<BoxCollider>().enabled = false;
        GetComponent<TextMesh>().text="";
		puzzle = true;
        //position = Transform.position;
    }

    // Update is called once per frame
    void Update()
    {
   //     if (player.position.z <= 14)
			//Debug.Log("Detras");
   //         //transform.position = new Vector3(200, 200, 200);
   //     else
   //         transform.position = position;
		if (activate.transform.position.y < -1.0f){
			if (puzzle){
				if (GetComponent<TextMesh>().text.Length == 4 && GetComponent<TextMesh>().text != "" && GetComponent<TextMesh>().text != "1826"){
					if(GetComponent<TextMesh>().text.Length == 4 && GetComponent<TextMesh>().text == "8314")
						Debug.Log("Que listillo tu, ¿No serás informático?");
					Debug.Log("Fallo");
					GetComponent<TextMesh>().text="Error";
					//sleep a second
					GetComponent<TextMesh>().text="";
				}
				else if(GetComponent<TextMesh>().text.Length == 4 && GetComponent<TextMesh>().text == "1826"){
					Debug.Log("Acierto");
					GetComponent<TextMesh>().text="Open";
					puzzle = false;
					door.GetComponent<BoxCollider>().enabled = true;
                    tp1.SetActive(true);
                    tp2.SetActive(true);
                    Destroy(pared);
					if(!hecho){
						script.nextHint();
						hecho = true;
					}
				}
			}
			else
				GetComponent<TextMesh>().text="Open";
		}
		else
				GetComponent<TextMesh>().text="";
    }
}
