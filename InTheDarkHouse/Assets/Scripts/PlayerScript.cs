using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    //KeyCode rightArrow = KeyCode.RightArrow;
    //KeyCode leftArrow = KeyCode.LeftArrow;
    //KeyCode upArrow = KeyCode.UpArrow;
    //KeyCode downArrow = KeyCode.DownArrow;

    Animator animator;

    public AnimationClip walkUp;
    public AnimationClip walkLeft;
    public AnimationClip walkDown;
    public AnimationClip walkRight;



    public float speed;

    private Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool(walkLeft.name, true);
            //walkLeft.Play("PlayerWalkLeft");
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
    //void FixedUpdate()
    //{
    //    //Store the current horizontal input in the float moveHorizontal.
    //    float moveHorizontal = Input.GetAxis("Horizontal");

    //    //Store the current vertical input in the float moveVertical.
    //    float moveVertical = Input.GetAxis("Vertical");

    //    //Use the two store floats to create a new Vector2 variable movement.
    //    Vector2 movement = new Vector2(moveHorizontal, moveVertical);

    //    //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
    //    //rigidbody.AddForce(movement * speed);
    //}

    // Update is called once per frame
    //   void Update () {
    //       if (Input.GetKeyDown(rightArrow))
    //       {

    //       }

    //}
}
