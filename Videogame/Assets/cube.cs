using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
  
    public GameObject colision;
    public GameObject puertasalida;
    public GameObject rojo;
    public GameObject verde;

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
            rojo.SetActive(false);
            verde.SetActive(true);
            //Destroy(puerta);
            //puerta.GetComponent("Interactable").enabled = true;
        }
    }

    
}
