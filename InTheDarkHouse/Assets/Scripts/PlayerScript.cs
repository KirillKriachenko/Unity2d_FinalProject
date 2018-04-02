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

    public GameObject myLight;
    public bool lightPicked;
    public float distance;
    public Camera inventoryCamera;
    public Camera playerCamera;
    public float speed;

    private Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.enabled = false;

        lightPicked = false;
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.B))
        {
            Debug.Log("Click B");
            if (inventoryCamera.enabled == false)
            {
                playerCamera.enabled = false;
                inventoryCamera.enabled = true;
            }
            else
            {
                inventoryCamera.enabled = false;
                playerCamera.enabled = true;
            }
        }
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

        if (Input.GetKeyUp(KeyCode.E))
        {
            Debug.Log("E - pressed");
            if (doorObjectScript.openable)
            {
                doorObjectScript.openDoor();
                
            }
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            if (Vector2.Distance(this.transform.position, myLight.transform.position) < distance)
            {
                if (lightPicked == false)
                {
                    lightPicked = true;
                    return;
                }
                if (lightPicked == true)
                {
                    lightPicked = false;
                }
            }
            
        }

        if (lightPicked == true)
        {
            myLight.transform.SetPositionAndRotation(this.transform.position, this.transform.rotation);
        }
    }
   
}
