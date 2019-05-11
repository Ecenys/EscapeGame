using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pianito : MonoBehaviour
{
    private ArrayList cancion = new ArrayList{ 10, 9, 10, 9, 10, 5, 8, 6, 3 };
    public ArrayList input = new ArrayList { };
    public GameObject cuadro;
    public GameObject rojo;
    public GameObject verde;
    public GameObject puerta;
    public AudioSource source;
    public bool sonido = true;
    public AudioClip clip;
    public int elementos;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        elementos = input.Count;
        for(int i=0; i<elementos; i++)
        {
            if (!cancion[i].Equals(input[i]))
            {
                input.Clear();
            }
            if ( i == 8 && (cancion[i].Equals(input[i])))
            {
                rojo.SetActive(false);
                verde.SetActive(true);
                puerta.GetComponent<BoxCollider>().enabled = true;
                if(sonido == true)
                {
                    source.Play();
                    source.PlayOneShot(clip, 2f);
                }
                sonido = false;
                //abrir puerta
                //cuadro.GetComponent<BoxCollider>().enabled = true;
            }
        }
    }
}
