using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3 : MonoBehaviour
{
    public GameObject controller1;
    public GameObject controller2;
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(controller1.transform.position, transform.position) < 0.1f || Vector3.Distance(controller2.transform.position, transform.position) < 0.1f)
        //acciones extra (movimiento npc)
        {
            Destroy(player);
            Application.LoadLevel("Room3");
        }
            
        //acciones extra (movimiento npc)
        if (Input.GetKeyDown( KeyCode.F ))
			Application.LoadLevel("Room3");
    }

}
