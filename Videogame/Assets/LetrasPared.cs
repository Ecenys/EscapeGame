using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetrasPared : MonoBehaviour
{
    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;
    public GameObject texto4;
    public GameObject cuadro;
    public AudioSource source;
    public bool sonido = true;
	
	public GodScript script;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(texto1.GetComponent<TextMesh>().text=="D" && texto2.GetComponent<TextMesh>().text == "E" && texto3.GetComponent<TextMesh>().text == "A" && texto4.GetComponent<TextMesh>().text == "F")
        {
            cuadro.GetComponent<BoxCollider>().enabled = true;
            if (sonido == true)
            {
                source.Play();
                sonido = false;
				
				script.nextHint();
				
            }
        }  
    }
    
}
