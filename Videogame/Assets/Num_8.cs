using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Num_8 : MonoBehaviour
{
    // Start is called before the first frame update
    public PasswordB passA;
    public AudioSource source;
    public AudioClip op;

    public void press()
    {
        source.PlayOneShot(op, 0.5f);
        passA.num_oct();
    }
}
