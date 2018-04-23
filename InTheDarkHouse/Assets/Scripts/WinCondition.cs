using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour {


    public GameObject playerCamera;
    public GameObject winCamera;
    public Font myFont;
    private bool showGUI = false;

    public Texture2D buttonStartTexture;

    private string text;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        if (showGUI == true)
        {
            GUIStyle myStile = new GUIStyle(GUI.skin.label);
            //myStile.font = myFont;

            //Font myFont = myStile; //(Font)Resources.Load("Fonts/comic", typeof(Font));
            myStile.font = myFont;
            myStile.fontSize = 35;

            GUI.color = Color.green;
            GUI.Label(new Rect(Screen.width/2, Screen.height/2 - 50, 200, 200), "You escape from this house and survive - CONGRATULATIONS");
            if (GUI.Button(new Rect(Screen.width/2 - 200, Screen.height/2 - 300, 100, 20), buttonStartTexture))
            {
                Application.LoadLevel("Level1");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered enter");
        if (other.tag == "Player" && this.name == "WinChoose")
        {
            
            showGUI = true;
            playerCamera.SetActive(false);
            winCamera.SetActive(true);
        }
    }
}
