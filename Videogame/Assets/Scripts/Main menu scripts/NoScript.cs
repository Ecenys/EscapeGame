using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoScript : MonoBehaviour
{
    public GameObject controller1, controller2;
	public GameObject yes, sure;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(controller1.transform.position, transform.position) < 1 || Vector3.Distance(controller2.transform.position, transform.position) < 1 ){
			yes.SetActive(false);
			sure.SetActive(false);
			this.gameObject.SetActive(false);
		}
    }
}
