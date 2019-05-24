using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject text;
    public GameObject door;
    public GameObject textScore;

    private float timer = 0.00f;
    private float score;
    private int hours;
    private int minutes;
    private int seconds;
    private Vector3 rotation = new Vector3(0, 90, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0.00f;
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
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
        textScore.SetActive(true);
        hours = (int)score / 3600;
        minutes = ((int)score % 3600) / 60;
        seconds = ((int)score % 3600) % 60;
        textScore.GetComponent<TextMesh>().text = hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
        text.SetActive(true);
    }
}
