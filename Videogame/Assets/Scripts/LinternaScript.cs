using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinternaScript : MonoBehaviour
{
    public GameObject linterna;
	public Transform derecha;

    void Start()
    {
        linterna.SetActive(false);
    }
	
	void Update()
    {
		if(Vector3.Distance(derecha.position, transform.position) < 0.5){
			linterna.SetActive(true);
			Destroy(this);
		}
	}

}
