using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalAudio : MonoBehaviour
{

    public GameObject a;
    private AudioSource cosa;
    private bool counter;

    // Start is called before the first frame update
    void Start()
    {
        cosa = a.GetComponent<AudioSource>();
        counter = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!counter)
        {
            //Cerrar la puerta de atras?
            cosa.Play();
            counter = true;
        }
    }
}
