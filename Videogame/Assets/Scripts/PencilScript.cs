using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilScript : MonoBehaviour
{
	public GameObject board;
	public GameObject ink;
	
	private float time = 0;
	
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == board){
			time += Time.timeScale;
			if (time >= 0.5f) //para evitar la generación excesiva de ink
				Instantiate(ink, new Vector3(board.transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
    }
}
