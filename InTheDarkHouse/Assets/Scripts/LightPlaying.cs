using Light2D;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPlaying : MonoBehaviour {

    public bool picked = false;
    public GameObject light;
    public GameObject player;
    public Collider2D playerColider;
    public Font myFont;

    bool showCandleText = false;

    public float end = 5.0f;
    public float start = 0.0f;

    public Texture pickedItem;

    public int candleHealth;

    private bool showTips;
    // Use this for initialization
    void Start () {
        candleHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {
        if (picked == true)
        {
            showCandleText = true;

            //light.GetComponent<LightSprite>().Color.a = 0.6f;
            //Vector3 playerPostition = 
            //= player.transform.position.x;
            //Debug.Log(light.transform.position.x.ToString());
            //light.transform.position.y = player.transform.position.y;
        }
        //else if (picked == false)
        //{
        //    light.GetComponent<LightSprite>().Color.a = 0.5f;
        //}
	}


    void OnGUI()
    {
        if (showCandleText == true)
        {
            GUIStyle myStile = new GUIStyle(GUI.skin.label);
            //myStile.font = myFont;

            //Font myFont = myStile; //(Font)Resources.Load("Fonts/comic", typeof(Font));
            myStile.font = myFont;
            myStile.fontSize = 35;

            GUI.color = Color.red;
            GUI.Label(new Rect(50, 50, 200, 200), "Candle: " + candleHealth.ToString() + "%", myStile);
            Update();
        }

        //if (showTips == true)
        //{
        //    GUI.color = Color.cyan;
        //    GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2, 100, 100), "Press 'F' to pick up/put down");
        //}
    }

    public void candleH(int demage)
    {
        if (start < end)
        {
            start += Time.deltaTime;
            // execute block of code here
        }
        else
        {
            candleHealth -= demage;
            if (candleHealth <= 0)
            {
                player.GetComponent<PlayerScript>().lightPicked = false;
                player.GetComponent<PlayerScript>().inventory.RemoveItem(pickedItem);
                Destroy(player.GetComponent<PlayerScript>().myLight);
            }
            start = 0.0f;
        }
    }


    public void OnTriggerEnter2D()
    {
        if (picked == false)
        {
         
            picked = true;
            Update();
        }

        if (picked == true)
        {

            picked = false;
        }
    }
}
