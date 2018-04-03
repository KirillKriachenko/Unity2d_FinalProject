using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demage : MonoBehaviour
{
    public float end = 5.0f;
    public float start = 0.0f;

    private int health = 100;
    private bool playerExit;

    // Use this for initialization
    void Start()
    {
        playerExit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerExit == true)
        {
            if (start < end)
            {
                start += Time.deltaTime;
                // execute block of code here
            }
            else
            {
                health -= 10;
                start = 0.0f;
            }

        }
       

    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerExit = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerExit = false;
        }
    }

    void OnGUI()
    {

        GUI.color = Color.red;
        GUI.Label(new Rect(50, Screen.height - 50, 100, 100),"Health: " + health.ToString());
        Update();
    }
}
