using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseScript : MonoBehaviour
{
	public GameObject fuse1;
	public GameObject fuse2;
	public GameObject fuse3;
	
	public GameObject position1;
	public GameObject position2;
	public GameObject position3;
	
	public GameObject activate;

    public GameObject lintern;
	
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (fuse1.transform.position == position1.transform.position && fuse2.transform.position == position3.transform.position && fuse3.transform.position == position2.transform.position)
        {
            activate.transform.position = new Vector3(0.0f, -2.0f, 0.0f);

            lintern.SetActive(false);
        }
    }
}
