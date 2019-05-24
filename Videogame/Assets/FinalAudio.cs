using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalAudio : MonoBehaviour
{

    public GameObject a;
    public GameObject coll;
    private AudioSource cosa;
    private bool counter;
    private readonly float timer = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        cosa = a.GetComponent<AudioSource>();
        counter = false;
        Destroy(coll, timer);
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
