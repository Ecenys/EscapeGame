using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Num_2 : MonoBehaviour
{

    public passwordA passA;
    public AudioSource source;
    public AudioClip op;

    public void press()
    {
        source.PlayOneShot(op, 0.5f);
        passA.num_two();
    }
}
