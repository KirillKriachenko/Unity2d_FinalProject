using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPlaying : MonoBehaviour {


    private bool picked = false;
    public GameObject light;
    public GameObject player;
    public Collider2D playerColider;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (picked == true)
        {
            //Vector3 playerPostition = 
            //= player.transform.position.x;
            //Debug.Log(light.transform.position.x.ToString());
            //light.transform.position.y = player.transform.position.y;
        }
	}


    public void OnTriggerEnter2D()
    {
        Debug.Log("Entered to trigger");
        Debug.Log("F pressed");
        if (picked == false)
        {
            picked = true;
            Debug.Log("picked = true");
            Update();
        }

        if (picked == true)
        {
            picked = false;
        }
    }
}
