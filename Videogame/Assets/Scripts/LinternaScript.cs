using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinternaScript : MonoBehaviour
{
    public GameObject linterna;

    // Start is called before the first frame update
    void Start()
    {
        linterna.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == linterna)
        {
            linterna.SetActive(false);
            Destroy(this);
        }
    }

}
