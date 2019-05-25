using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Num_hast1 : MonoBehaviour
{
    // Start is called before the first frame update
    public passwordA passA;
    public AudioSource source;
    public AudioClip op;

    public void press()
    {
        source.PlayOneShot(op, 0.5f);
        passA.num_Hast();
    }
}
