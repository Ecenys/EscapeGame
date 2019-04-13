using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
  
    public GameObject colision;
    public GameObject puertasalida;
    public GameObject rojo;
    public GameObject verde;
    public AudioSource source;
    public AudioClip alarmarara;
    private int var = 1;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
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
            if (var == 1)
            {
                source.PlayOneShot(alarmarara, 0.5f);
                var = 0;
            }
            //Destroy(puerta);
            //puerta.GetComponent("Interactable").enabled = true;
        }
    }

    
}
