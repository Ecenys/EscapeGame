using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentiladorScript : MonoBehaviour
{
	public GameObject activador;
	public bool enable;
	public int velocidad;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activador.transform.position.y < -1.0f || enable){
			transform.Rotate(Vector3.up * Time.deltaTime * velocidad, Space.World);
			//transform.rotation = Quaternion.Slerp(transform.rotation, new Quaternion(0, 1, 0, 1),  Time.deltaTime);
		}
    }
}
