using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {
    public ParticleSystem particle;
    private bool awake = false;
    private float timeCount = 0;
	// Use this for initialization
	void Start () {
        awake = false;
	}
	
	// Update is called once per frame
	void Update () {
        while (awake == true)
        {
            timeCount += Time.deltaTime;
            if (timeCount > 2)
            {
                Destroy(this);
            }
        }
        //if (awake == true)
        //{
        //    timeCount += Time.deltaTime;

        //}
       
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            particle.Play();
            awake = true;
        }
    }
}
