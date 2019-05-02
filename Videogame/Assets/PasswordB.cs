using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordB : MonoBehaviour
{
    public GameObject box;
    public GameObject empty;


    private int num_1 = 0;
    private int num_2 = 0;
    public int num_3 = 0;

    private int num_4 = 0;
    private int num_5 = 0;
    private int num_6 = 0;

    private int num_7 = 0;
    private int num_8 = 0;
    private int num_9 = 0;

    private int num_0 = 0;
    private int num_ast = 0;
    private int num_hast = 0;

    private bool digit_0 = false;
    private bool digit_1 = false;
    private bool digit_2 = false;
    private bool digit_3 = false;
    private bool digit_4 = false;
    private bool digit_5 = false;

    public AudioClip op;
    public AudioSource source;
    public int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (digit_0 && digit_1 && digit_2 && digit_3 && digit_4 && digit_5) 
        {
            source.PlayOneShot(op, 0.5f);
            OpenB();
            Instantiate(box, new Vector3(empty.transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }



    // #4590*

    // num de palabras de cada frase en la luna


    public void num_one()
    {
        digit_0 = false;
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
        digit_5 = false;
    }

    public void num_two()
    {
        digit_0 = false;
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
        digit_5 = false;
    }

    public void num_three()
    {
        digit_0 = false;
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
        digit_5 = false;
    }


    public void num_four()
    {
        if (digit_0) { digit_1 = true; }
        else
        {
            digit_0 = false;
            digit_1 = false;
            digit_2 = false;
            digit_3 = false;
            digit_4 = false;
            digit_5 = false;
        }
    }

    public void num_five()
    {
        if (digit_0 && digit_1) { digit_2 = true; }
        else
        {
            digit_0 = false;
            digit_1 = false;
            digit_2 = false;
            digit_3 = false;
            digit_4 = false;
            digit_5 = false;
        }
    }

    public void num_six()
    {
        digit_0 = false;
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
        digit_5 = false;
    }


    public void num_seven()
    {
        digit_0 = false;
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
        digit_5 = false;

    }

    public void num_oct()
    {
        digit_0 = false;
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
        digit_5 = false;
    }

    public void num_nine()
    {
        if (digit_0 && digit_1 && digit_2) { digit_3 = true; }
        else
        {
            digit_0 = false;
            digit_1 = false;
            digit_2 = false;
            digit_3 = false;
            digit_4 = false;
            digit_5 = false;
        }
    }
    public void num_zero()
    {
        if (digit_0 && digit_1 && digit_2 && digit_3) { digit_4 = true; }
        else
        {
            digit_0 = false;
            digit_1 = false;
            digit_2 = false;
            digit_3 = false;
            digit_4 = false;
            digit_5 = false;
        }
    }

    public void num_Ast()
    {
        if (digit_0 && digit_1 && digit_2 && digit_3 && digit_4) { digit_5 = true; }
        else
        {
            digit_0 = false;
            digit_1 = false;
            digit_2 = false;
            digit_3 = false;
            digit_4 = false;
            digit_5 = false;
        }
    }

    public void num_Hast()
    {
        digit_0 = true;
    }




    void OpenB()
    {
        //Aparece la llave de la derecha
        //box.GetComponent<BoxCollider>().enabled = true;
        box.SetActive(true);
        a = 2;

    }
}
