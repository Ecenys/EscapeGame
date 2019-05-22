using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSelect : MonoBehaviour
{
    public int room=0;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(room == 1)
        {

        }
    }
}
