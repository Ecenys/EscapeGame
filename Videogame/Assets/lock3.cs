using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lock3 : MonoBehaviour
{
    public GameObject box;
    public GameObject colision;
    public GameObject quit;
    public AudioSource source;
    public AudioClip op;
    public int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision col)
    {
        a = 3;
        if (col.gameObject.tag == "KeyCloset")
        {
            source.PlayOneShot(op, 0.5f);
            box.GetComponent<BoxCollider>().enabled = true;
            
            Destroy(quit);
            Destroy(this);
            a = 2;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
