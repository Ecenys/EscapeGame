using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusePositionScript : MonoBehaviour
{
	public GameObject position;
	public GameObject father;
	public int ID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == position.transform.position)
			switch (ID)
			{
			  case 1:
				  father.GetComponent<FuseScript>().Fuse1 = true;
				  break;
			  case 2:
				  father.GetComponent<FuseScript>().Fuse2 = true;
				  break;
			  case 3:
				  father.GetComponent<FuseScript>().Fuse3 = true;
				  break;
			}
		else
			switch (ID)
			{
			  case 1:
				  father.GetComponent<FuseScript>().Fuse1 = false;
				  break;
			  case 2:
				  father.GetComponent<FuseScript>().Fuse2 = false;
				  break;
			  case 3:
				  father.GetComponent<FuseScript>().Fuse3 = false;
				  break;
			}
    }
}
