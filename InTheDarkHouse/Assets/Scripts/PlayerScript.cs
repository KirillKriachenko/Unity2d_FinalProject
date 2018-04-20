using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    public Animator animator;

    public AnimationClip walkUp;
    public AnimationClip walkLeft;
    public AnimationClip walkDown;
    public AnimationClip walkRight;

    public Inventory inventory;

    public GameObject myLight;
    public bool lightPicked;
    public float distance;
    public Camera playerCamera;
    public GameObject textCamera;
    public float speed;

    public GameObject text;

    public GameObject objectForText;
    public bool showText;

    //public DisplayText displayText;
    private bool flag;

    private Rigidbody2D rigidbody;

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.enabled = false;

        //textCamera = GameObject.FindGameObjectWithTag("Cameratext");
        //textCamera = GetComponent<GameObject>();

        flag = false;

        lightPicked = false;

        showText = false;
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