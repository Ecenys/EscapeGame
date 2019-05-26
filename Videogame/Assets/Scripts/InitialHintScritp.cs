using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialHintScritp : MonoBehaviour
{
	public GameObject player;
	public GodScript script;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) < 0.3f)
			script.specialAudio(1);
    }
}
