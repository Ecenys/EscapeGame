using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public GameObject puerta1;
    public GameObject puerta2;
    public GameObject puerta3;
    public GameObject puerta4;
    public GameObject puerta5;
    public GameObject puerta6;
    public GameObject puerta7;
    public GameObject puerta8;
    public GameObject puerta9;
    public GameObject puertabloqueada1;
    public GameObject puertabloqueada2;
    public GameObject puertabloqueada3;
    public AudioClip sonidito;
    private int var = 1;
    private AudioSource source;
    private float volumenbajo = .5f;
    private float volumenalto = 1.0f;
    private Vector3 vector;
    private bool condicion1 = false;
    private bool condicion2 = false;

    // Start is called before the first frame update
    void Start()
    {
        vector.x = 0;
        vector.y = 190;
        vector.z = 0;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        /*Uno*/
        if ((puerta1.transform.rotation.eulerAngles.y >= 269) && (puerta5.transform.rotation.eulerAngles.y <= 225) && (puerta9.transform.rotation.eulerAngles.y >= 269) && (puerta2.transform.rotation.eulerAngles.y >= 269) && (puerta3.transform.rotation.eulerAngles.y >= 269) && (puerta4.transform.rotation.eulerAngles.y >= 269) && (puerta6.transform.rotation.eulerAngles.y >= 269) && (puerta7.transform.rotation.eulerAngles.y >= 269) && (puerta8.transform.rotation.eulerAngles.y >= 269))
        {
            //Destroy(puertabloqueada1);
        }
        /*Dos*/
        if ((puerta1.transform.rotation.eulerAngles.y <= 225) && (puerta5.transform.rotation.eulerAngles.y >= 269) && (puerta9.transform.rotation.eulerAngles.y <= 225) && (puerta2.transform.rotation.eulerAngles.y >= 269) && (puerta3.transform.rotation.eulerAngles.y >= 269) && (puerta4.transform.rotation.eulerAngles.y >= 269) && (puerta6.transform.rotation.eulerAngles.y >= 269) && (puerta7.transform.rotation.eulerAngles.y >= 269) && (puerta8.transform.rotation.eulerAngles.y >= 269))
        {
            //Destroy(puertabloqueada1);
        }
        /*Tres*/
        if ((puerta1.transform.rotation.eulerAngles.y <= 225) && (puerta5.transform.rotation.eulerAngles.y <= 225) && (puerta9.transform.rotation.eulerAngles.y <= 225) && (puerta2.transform.rotation.eulerAngles.y >= 269) && (puerta3.transform.rotation.eulerAngles.y >= 269) && (puerta4.transform.rotation.eulerAngles.y >= 269) && (puerta6.transform.rotation.eulerAngles.y >= 269) && (puerta7.transform.rotation.eulerAngles.y >= 269) && (puerta8.transform.rotation.eulerAngles.y >= 269))
        {
            //Destroy(puertabloqueada1);
        }
        /*Cuatro*/
        if ((puerta1.transform.rotation.eulerAngles.y <= 225) && (puerta3.transform.rotation.eulerAngles.y <= 225) && (puerta7.transform.rotation.eulerAngles.y <= 225) && (puerta9.transform.rotation.eulerAngles.y <= 225) && (puerta2.transform.rotation.eulerAngles.y >= 269) && (puerta4.transform.rotation.eulerAngles.y >= 269) && (puerta5.transform.rotation.eulerAngles.y >= 269) && (puerta6.transform.rotation.eulerAngles.y >= 269) && (puerta8.transform.rotation.eulerAngles.y >= 269))
        {
            condicion1 = true;
        }
        /*Cinco*/
        if ((puerta1.transform.rotation.eulerAngles.y <= 225) && (puerta3.transform.rotation.eulerAngles.y <= 225) && (puerta5.transform.rotation.eulerAngles.y <= 225) && (puerta7.transform.rotation.eulerAngles.y <= 225) && (puerta9.transform.rotation.eulerAngles.y <= 225) && (puerta2.transform.rotation.eulerAngles.y >= 269) && (puerta4.transform.rotation.eulerAngles.y >= 269) && (puerta6.transform.rotation.eulerAngles.y >= 269) && (puerta8.transform.rotation.eulerAngles.y >= 269))
        {
            
        }
        /*Seis*/
        if ((puerta1.transform.rotation.eulerAngles.y <= 225) && (puerta3.transform.rotation.eulerAngles.y <= 225) && (puerta4.transform.rotation.eulerAngles.y <= 225) && (puerta6.transform.rotation.eulerAngles.y <= 225) && (puerta7.transform.rotation.eulerAngles.y <= 225) && (puerta9.transform.rotation.eulerAngles.y <= 225) && (puerta2.transform.rotation.eulerAngles.y >= 269) && (puerta5.transform.rotation.eulerAngles.y >= 269) && (puerta8.transform.rotation.eulerAngles.y >= 269))
        {
            condicion2 = true;
        }

        if((condicion1 == true) && (condicion2 == true))
        {
            puertabloqueada3.GetComponent<BoxCollider>().enabled = true;
            if (var == 1)
            {
                float vol = Random.Range(volumenbajo, volumenalto);
                source.PlayOneShot(sonidito, vol);
                var = 0;
            }
        }
    }

}
