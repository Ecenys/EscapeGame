using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public GameObject puerta1;
    public GameObject colision;
    public GameObject puerta7;
    public GameObject puerta;
    public GameObject puertasalida;
	public GameObject bloqueo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "glass_jar")
        {
            Debug.Log("Puerta 1 ángulos:" + puerta1.transform.rotation.eulerAngles.y);
            Debug.Log("Puerta 7 ángulos:" + puerta7.transform.rotation.eulerAngles.y);
            if ((puerta1.transform.rotation.eulerAngles.y <= 190) && (puerta7.transform.rotation.eulerAngles.y <= 190))
            {
                Destroy(puerta);
            }
            puertasalida.GetComponent<Event>().tocado = true;
			Destroy(bloqueo);
            //Destroy(puerta);
            //puerta.GetComponent("Interactable").enabled = true;
        }
    }

    
}
