﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube2 : MonoBehaviour
{
    public bool solved = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Domino40")
        {
            
            solved = true;
        }
    }


}