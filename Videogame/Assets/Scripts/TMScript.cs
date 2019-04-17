using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMScript : MonoBehaviour
{
	public GameObject activate;
	
	private bool puzzle;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text="";
		puzzle = true;
    }

    // Update is called once per frame
    void Update()
    {
		if (activate.transform.position.y < -1.0f){
			if (puzzle){
				if (GetComponent<TextMesh>().text.Length == 4 && GetComponent<TextMesh>().text != "" && GetComponent<TextMesh>().text != "1826"){
					if(GetComponent<TextMesh>().text.Length == 4 && GetComponent<TextMesh>().text == "4129")
						Debug.Log("Que listillo tu, ¿No?");
					Debug.Log("Fallo");
					GetComponent<TextMesh>().text="Error";
					//sleep a second
					GetComponent<TextMesh>().text="";
				}
				else if(GetComponent<TextMesh>().text.Length == 4 && GetComponent<TextMesh>().text == "1826"){
					Debug.Log("Acierto");
					GetComponent<TextMesh>().text="Open";
					puzzle = false;
				}
			}
			else
				GetComponent<TextMesh>().text="Open";
		}
		else
				GetComponent<TextMesh>().text=" ";
    }
}
