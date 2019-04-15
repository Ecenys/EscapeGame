using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseScript : MonoBehaviour
{
	public bool Fuse1;
	public bool Fuse2;
	public bool Fuse3;
    // Start is called before the first frame update
    void Start()
    {
        Fuse1=false;
		Fuse2=false;
		Fuse3=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Fuse1 && Fuse2 && Fuse3)
			Debug.Log("Abierta");
    }
}
