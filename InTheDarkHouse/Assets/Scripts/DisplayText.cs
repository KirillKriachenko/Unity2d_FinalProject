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
    //public BoxCollider2D trigger;

    public Texture foundObject;

    public Inventory inventory;
	// Use this for initialization
	void Start () {

        //textCamera = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
    }

    public bool displayText()
    {
        return true;
    }

    public void showText()
    {
        textCamera.gameObject.SetActive(true);
        playerCamera.SetActive(false);
        text.text = noteText;
        text.enabled = true;
    }

    public void giveKey()
    {
        text.enabled = false;
        textCamera.SetActive(false);
        playerCamera.SetActive(true);

        inventory.AddItem(foundObject);
    }

}
