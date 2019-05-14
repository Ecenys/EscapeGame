using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationScript : MonoBehaviour
{

    public GameObject colision;
    public GameObject puertasalida;
    public GameObject rojo;
    public GameObject verde;
    public AudioSource source;
    public AudioClip alarmarara;
    public AudioClip error;
    public AudioClip acierto;
    public GameObject colPuerta;
    private int var = 1;
    public GameObject tp1;
    public GameObject tp2;
    public GameObject tp3;
    public GameObject seis;
    public GameObject cuatro;

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
        if (seis.GetComponent<cube>().solved == true && cuatro.GetComponent<cube2>().solved == true)
        {
            puertasalida.GetComponent<BoxCollider>().enabled = true;
            rojo.SetActive(false);
            verde.SetActive(true);
            colPuerta.SetActive(false);
            tp1.SetActive(true);
            tp2.SetActive(true);
            tp3.SetActive(true);
            if (var == 1)
            {
                source.PlayOneShot(alarmarara, 0.5f);
                var = 0;
            }
            //Destroy(puerta);
            //puerta.GetComponent("Interactable").enabled = true;
        }
        else
        {
            source.PlayOneShot(error, 0.5f);
        }
    }


}