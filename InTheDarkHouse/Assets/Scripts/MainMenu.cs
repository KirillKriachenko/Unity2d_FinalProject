using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;

    public Texture2D buttonStartTexture;
    public Texture2D buttonExitTexture;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 20),buttonStartTexture))
        {
            Application.LoadLevel("Level1");
        }
    }
}
