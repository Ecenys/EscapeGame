using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraftScript : MonoBehaviour
{	
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ink"){
			Destroy(other.gameObject);
		}
    }
}
