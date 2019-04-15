using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text="";
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<TextMesh>().text.Length == 4 && GetComponent<TextMesh>().text != "" && GetComponent<TextMesh>().text != "1234"){
			Debug.Log("Fallo");
			GetComponent<TextMesh>().text="Error";
			//sleep a second
			GetComponent<TextMesh>().text="";
		}
		else if(GetComponent<TextMesh>().text.Length == 4 && GetComponent<TextMesh>().text == "1234"){
			Debug.Log("Acierto");
			GetComponent<TextMesh>().text="Open Door";
		}
    }
}
