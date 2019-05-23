using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Light2script : MonoBehaviour
{
	public Transform activator;

    private string sceneName;
	
    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "Room3" || sceneName == "Room4")
        {
            GetComponent<Light>().enabled = true;
        }
        else
            GetComponent<Light>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(activator.position.y < -1.0f){
			GetComponent<Light>().enabled = true;
		}
    }
}
