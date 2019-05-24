using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject text;
    public GameObject door;

    public float timer = 0.00f;
    private Vector3 rotation = new Vector3(0, 90, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if ((timer <= 1.0f) && (timer > 0.00f))
        {
            Application.LoadLevel("Main menu");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        door.transform.Rotate(rotation);
        timer = 9.00f;
        text.SetActive(true);
    }
}
