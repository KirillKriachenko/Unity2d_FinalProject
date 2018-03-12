using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider playerColider)
    {
        if (playerColider.tag == "Player")
        {
            transform.localPosition = new Vector3(0, 0, 0);
            print(transform.localPosition.y);
        }
    }
}
