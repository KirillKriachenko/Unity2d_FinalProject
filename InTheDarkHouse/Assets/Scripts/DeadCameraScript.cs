using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadCameraScript : MonoBehaviour {

    public Texture2D buttonStartTexture;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width/2, Screen.height/2, 100, 50), buttonStartTexture))
        {
            Application.LoadLevel("Level1");
        }
    }
}
