﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2Script : MonoBehaviour {

    public List<GameObject> doorsList = new List<GameObject>();
    public float distance;
    //public bool isOpenable;
    //public Texture itemNeeded;

    public PlayerScript playerScript;

    private int counter = 0;

    private bool showGUI;
    private bool showNeeds;

    private string doorName;

    //public AudioClip doorsSound;
 

    // Use this for initialization
    void Start () {
       
    }

    public void OnGUI()
    {
        if (showGUI == true)
        {
            GUI.color = Color.cyan;
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 60, 60), "Press 'E' to open Door");
        }
        if (showNeeds == true)
        {
            GUI.color = Color.cyan;
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 60, 60), "I need Key for this door");
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Door")
        {
            Debug.Log("Triggered enter DOOR");
            showGUI = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Door")
        {
            Debug.Log("Triggered exit DOOR");
            // Destroy everything that leaves the trigger
            showGUI = false;
            showNeeds = false;
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyUp(KeyCode.E))
        {
            showGUI = false;
            for (int i = 0; i < doorsList.Count; i++)
            {
                Debug.Log("Loop number" + i);
                try
                {
                    if (Vector2.Distance(this.transform.position, doorsList[i].transform.position) < distance)
                    {
                        Debug.Log("Distance passed");

                        if (GameObject.Find(doorsList[i].name).GetComponent<DoorIteraction>().openDoor() == true)
                        {
                            doorName = doorsList[i].name;
                            doorsList.RemoveAt(i);
                            Destroy(GameObject.Find(doorName));
                            break;
                        }
                        if (GameObject.Find(doorsList[i].name).GetComponent<DoorIteraction>().openDoor() == false)
                        {
                            showNeeds = true;
                            break;
                        }
                    }

                    //Debug.Log()
                }
                catch (System.Exception e)
                {
                    Debug.Log(e.Message);
                    throw;
                }
                
            }
        }
    }
    
}
