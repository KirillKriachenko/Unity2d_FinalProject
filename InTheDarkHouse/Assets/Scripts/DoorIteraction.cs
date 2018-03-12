using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorIteraction : MonoBehaviour {

    public bool openable;
    public bool locked;
    public GameObject itemNeeded;
    public GameObject door;
    public Animator animator;
    public AnimationClip animationClip;


	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        animator.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
