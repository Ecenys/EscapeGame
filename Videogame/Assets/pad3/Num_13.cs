﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Num_13 : MonoBehaviour
{

    public PasswordC passA;
    public AudioSource source;
    public AudioClip op;

    public void press()
    {
        source.PlayOneShot(op, 0.5f);
        passA.num_one();
    }
}
