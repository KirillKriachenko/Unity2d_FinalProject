using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demage : MonoBehaviour
{
    public float end = 5.0f;
    public float start = 0.0f;
    public Font myFont;
    public int fontSize;
    private int health = 100;
    private bool playerExit;

    public float damageStart = 0.0f;
    public float damageEnd = 3.0f;

    public bool showDamage;

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
                StopAllCoroutines();
                StartCoroutine("Blink");
                health -= 10;
                if (health <= 0)
                {
                    //Death.
                }

                
                start = 0.0f;
            }

        }
       

    }

    IEnumerator Blink()
    {
        while(true)
        {
            showDamage = true;
            yield return new WaitForSeconds(0.2f);
            showDamage = false;

            break;
        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "candle")
        {
            playerExit = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "candle")
        {
            playerExit = false;
        }
    }

    void OnGUI()
    {
        GUIStyle myStile = new GUIStyle(GUI.skin.label);
        //myStile.font = myFont;

        //Font myFont = myStile; //(Font)Resources.Load("Fonts/comic", typeof(Font));
        myStile.font = myFont;
        myStile.fontSize = 35;

        GUI.color = Color.red;
        GUI.Label(new Rect(50, Screen.height - 50, 200, 200),"Health: " + health.ToString(), myStile);
        Update();
    }
}
