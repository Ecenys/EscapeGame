using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public GameObject puerta1;
    public GameObject colision;
    public GameObject puerta7;
    public GameObject puerta;
    public GameObject puertasalida;
	public GameObject bloqueo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Domino64")
        {
            puertasalida.GetComponent<BoxCollider>().enabled = true;
			
            //Destroy(puerta);
            //puerta.GetComponent("Interactable").enabled = true;
        }
    }

    
}
