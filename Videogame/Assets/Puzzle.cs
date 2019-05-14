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
    public GameObject puertabloqueada2;
    public GameObject puertabloqueada3;
    public AudioClip sonidito;
    private int var = 1;
    private int var2 = 1;
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
        /*Dos*/

        /*Tres*/
   
        /*Cuatro*/
        if ((puerta1.transform.rotation.eulerAngles.y <= 225) && (puerta3.transform.rotation.eulerAngles.y <= 225) && (puerta7.transform.rotation.eulerAngles.y <= 225) && (puerta9.transform.rotation.eulerAngles.y <= 225) && (puerta2.transform.rotation.eulerAngles.y >= 269) && (puerta4.transform.rotation.eulerAngles.y >= 269) && (puerta5.transform.rotation.eulerAngles.y >= 269) && (puerta6.transform.rotation.eulerAngles.y >= 269) && (puerta8.transform.rotation.eulerAngles.y >= 269))
        {
            puertabloqueada2.GetComponent<BoxCollider>().enabled = true;
            if (var2 == 1)
            {
                float vol = Random.Range(volumenbajo, volumenalto);
                source.PlayOneShot(sonidito, 0.2f);
                var2 = 0;
            }
        }
        /*Cinco*/

        /*Seis*/
        if ((puerta1.transform.rotation.eulerAngles.y <= 225) && (puerta3.transform.rotation.eulerAngles.y <= 225) && (puerta4.transform.rotation.eulerAngles.y <= 225) && (puerta6.transform.rotation.eulerAngles.y <= 225) && (puerta7.transform.rotation.eulerAngles.y <= 225) && (puerta9.transform.rotation.eulerAngles.y <= 225) && (puerta2.transform.rotation.eulerAngles.y >= 269) && (puerta5.transform.rotation.eulerAngles.y >= 269) && (puerta8.transform.rotation.eulerAngles.y >= 269))
        {
            puertabloqueada3.GetComponent<BoxCollider>().enabled = true;
            if (var == 1)
            {
                float vol = Random.Range(volumenbajo, volumenalto);
                source.PlayOneShot(sonidito, 0.2f);
                var = 0;
            }
        }
            
 
    }

}
