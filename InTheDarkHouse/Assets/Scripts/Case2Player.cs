using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Case2Player : MonoBehaviour {

    public List<GameObject> casesList = new List<GameObject>();
    public float distance;
    private bool showGUI;

    public GameObject textCamera;
    public Text text;
    public Inventory inventory;

    private GameObject destroyObject;

    private int counter = 0;
    private int lastObjectCount = 0;

    // Use this for initialization
    void Start () {
        showGUI = false;
        textCamera.SetActive(false);
    }
	
    public void OnGUI()
    {
        if (showGUI == true)
        {
            GUI.color = Color.cyan;
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 50, 50), "Press 'Space' to open");
        }
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered enter");
        if (other.tag == "case")
        {
            showGUI = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "case")
        {
            showGUI = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            for (int i = 0; i < casesList.Count; i++)
            {
                try
                {
                    if (Vector2.Distance(this.transform.position, casesList[i].transform.position) < distance)
                    {
                        textCamera.SetActive(true);
                        text.text = GameObject.Find(casesList[i].name).GetComponent<DisplayText>().noteText;

                        inventory.AddItem(GameObject.Find(casesList[i].name).GetComponent<DisplayText>().foundObject);

                        destroyObject = casesList[i];
                        lastObjectCount = casesList.Count;


                    }
                    else
                    {
                        showGUI = false;
              
                    }
                }
                catch (System.Exception e)
                {
                    Debug.Log(e.Message);
                    throw;
                }

            }
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            
            
            textCamera.SetActive(false);
            showGUI = false;

            Destroy(destroyObject);
            casesList.RemoveAt(lastObjectCount);
        }
    }

    private void showTextFunction()
    {
      
    }
}
