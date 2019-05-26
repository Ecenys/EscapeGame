using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lock1 : MonoBehaviour
{
    public GameObject box;
    public GameObject colision;
	public GameObject fuse;
    
    
    public int a=0;
    // Start is called before the first frame update
    void Start()
    {
        fuse.SetActive(false);
    }

    void OnCollisionEnter(Collision col)
    {
        a = 3;
        if (col.gameObject.tag == "keyG")
        {
            box.GetComponent<BoxCollider>().enabled = true;
			GetComponent<Rigidbody>().useGravity =  true;
            a = 2;
			fuse.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
