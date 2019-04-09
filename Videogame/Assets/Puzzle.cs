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
    private Vector3 vector;

    // Start is called before the first frame update
    void Start()
    {
        vector.x = 0;
        vector.y = 190;
        vector.z = 0;
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
            puertabloqueada1.GetComponent<BoxCollider>().enabled = true;
        }
        /*Cinco*/
        if ((puerta1.transform.rotation.eulerAngles.y <= 225) && (puerta3.transform.rotation.eulerAngles.y <= 225) && (puerta5.transform.rotation.eulerAngles.y <= 225) && (puerta7.transform.rotation.eulerAngles.y <= 225) && (puerta9.transform.rotation.eulerAngles.y <= 225) && (puerta2.transform.rotation.eulerAngles.y >= 269) && (puerta4.transform.rotation.eulerAngles.y >= 269) && (puerta6.transform.rotation.eulerAngles.y >= 269) && (puerta8.transform.rotation.eulerAngles.y >= 269))
        {
            puertabloqueada2.GetComponent<BoxCollider>().enabled = true;
        }
        /*Seis*/
        if ((puerta1.transform.rotation.eulerAngles.y <= 225) && (puerta3.transform.rotation.eulerAngles.y <= 225) && (puerta4.transform.rotation.eulerAngles.y <= 225) && (puerta6.transform.rotation.eulerAngles.y <= 225) && (puerta7.transform.rotation.eulerAngles.y <= 225) && (puerta9.transform.rotation.eulerAngles.y <= 225) && (puerta2.transform.rotation.eulerAngles.y >= 269) && (puerta5.transform.rotation.eulerAngles.y >= 269) && (puerta8.transform.rotation.eulerAngles.y >= 269))
        {
            puertabloqueada3.GetComponent<BoxCollider>().enabled = true;
        }
    }

}
