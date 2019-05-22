using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GritoMujer : MonoBehaviour
{
    public AudioSource source;
    public bool var=false;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!var)
        {
            source.Play();
            var = true;
        }
    }
}
