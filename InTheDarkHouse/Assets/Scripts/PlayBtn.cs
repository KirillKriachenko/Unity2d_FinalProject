using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseEnter()
    {
        this.transform.localScale = new Vector3(0.29f, 0.29f, 0.29f);
        Update();
    }

    void OnMouseExit()
    {
        this.transform.localScale = new Vector3(0.2360869f, 0.2360869f, 0.2360869f);
        Update();
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel(1);
        }
    }
}
