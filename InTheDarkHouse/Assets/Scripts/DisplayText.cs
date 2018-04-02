using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour {

    [TextArea]
    public string  noteText;
    public Text text;
    public GameObject playerCamera;
    public GameObject textCamera;

    public GameObject foundObject;
	// Use this for initialization
	void Start () {

        //textCamera = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.E))
        {
            text.enabled = false;
            textCamera.SetActive(false);
            playerCamera.SetActive(true);
            Destroy(this);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("On trigger");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Entered");
            //textCamera.SetActive(true);
            textCamera.gameObject.SetActive(true);
            playerCamera.SetActive(false);
            text.text = noteText;
            text.enabled = true;
            //text.gameObject.SetActive(true);
           
            Update();

        }
    }
}
