using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pang : MonoBehaviour
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
        if (col.gameObject.tag == "pang")
        {

            Destroy(box);
            a = 2;
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
