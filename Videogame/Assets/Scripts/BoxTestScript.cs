using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnCollisionEnter (Collision col)
    {
        Debug.Log("pene");
    }
	void OnTriggerEnter(Collider other){
		Debug.Log("pene2");
    }
	public void pene(){
		
	}
	
}
