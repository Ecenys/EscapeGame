using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class num_32 : MonoBehaviour
{
    public PasswordB passA;
    public AudioSource source;
    public AudioClip op;

    public void press() {
        source.PlayOneShot(op, 0.5f);
        passA.num_three();
    }

}
