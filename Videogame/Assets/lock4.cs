using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lock4 : MonoBehaviour
{
    public GameObject box;
    public GameObject colision;


    public int a = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        a = 3;
        if (col.gameObject.tag == "keyBlade")
        {
            box.GetComponent<BoxCollider>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
            a = 2;
        }

    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
