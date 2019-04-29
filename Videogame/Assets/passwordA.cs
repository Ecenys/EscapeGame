using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passwordA : MonoBehaviour
{
    public GameObject box;
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

    private bool digit_1 = false;
    private bool digit_2 = false;
    private bool digit_3 = false;
    private bool digit_4 = false;

    public int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (digit_1 && digit_2 && digit_4 && digit_3) { OpenA(); }
    }



    // 1 -> M (1),  4->T (8), 5->F (7), 6-> S (6)

        // destrás del cuadro hay letras y tras uqe faltan, se coge la pass de la nota, y coges cada número con su posicion en la letra tras el cuado.
        //buscas la letra en el aparato que gira, y tienes el digito a poner.


    public void num_one()
    {
        num_1 = 1;
        digit_1 = true;
    }

    public void num_two()
    {
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
    }

    public void num_three()
    {
        num_3 = 3;
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
    }


    public void num_four()
    {
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
    }

    public void num_five()
    {
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
    }

    public void num_six()
    {
        if (digit_1 && digit_2 && digit_3) { num_6 = 1; digit_4 = true; }
    }


    public void num_seven()
    {
        if (digit_1 && digit_2) { num_7 = 1; digit_3 = true; }

    }

    public void num_oct()
    {
        if (digit_1){ num_8 = 1;  digit_2 = true;}
    }

    public void num_nine()
    {
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
    }
    public void num_zero()
    {
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
    }

    public void num_Ast()
    {
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
    }

    public void num_Hast()
    {
        digit_1 = false;
        digit_2 = false;
        digit_3 = false;
        digit_4 = false;
    }




    void OpenA()
    {

        box.GetComponent<BoxCollider>().enabled = true;
        a = 2;
        
    }
}
