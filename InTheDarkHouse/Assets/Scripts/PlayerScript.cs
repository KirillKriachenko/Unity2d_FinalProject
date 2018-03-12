using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    //KeyCode rightArrow = KeyCode.RightArrow;
    //KeyCode leftArrow = KeyCode.LeftArrow;
    //KeyCode upArrow = KeyCode.UpArrow;
    //KeyCode downArrow = KeyCode.DownArrow;

    public Animator animator;
    public Animation animation;

    public AnimationClip walkUp;
    public AnimationClip walkLeft;
    public AnimationClip walkDown;
    public AnimationClip walkRight;

    public DoorIteraction doorObjectScript;



    public float speed;

    private Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
        animator.enabled = false;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        { 
            animator.enabled = true;
            animator.Play(walkLeft.name);
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.enabled = false;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.enabled = true;
            animator.Play(walkRight.name);
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.enabled = false;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.enabled = true;
            animator.Play(walkUp.name);
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.enabled = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.enabled = true;
            animator.Play(walkDown.name);
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.enabled = false;
        }

        if (Input.GetKey(KeyCode.E))
        {
            if (doorObjectScript.openable)
            {
                doorObjectScript.animator.enabled = true;
            }
        }
    }
   
}
