using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitTP : MonoBehaviour
{
    public GameObject tpor;
    public GameObject tpentrada;
    public GameObject tpmusica;
    public GameObject tpotro;
    public GameObject tpJa;
    // Start is called before the first frame update
    void Start()
    {
        tpor.SetActive(true);
        tpentrada.SetActive(true);
        tpmusica.SetActive(true);
        tpotro.SetActive(true);
        tpJa.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
