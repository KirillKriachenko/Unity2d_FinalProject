using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorIteraction : MonoBehaviour {

    public bool openable;
    public bool locked;
    public bool open;
    public Texture itemNeeded;

    public PlayerScript playerInventory;
    public Inventory inventory;
    //public Animator animator;
    //public Animation anim;
    //public AnimationClip doorOpen;
    //public AnimationClip doorClose;

    //public GameObject doorObject;
    //public GameObject player;
    //public float distance;

    // Use this for initialization
    void Start () {
        open = false;
        //animator = GetComponent<Animator>();
        //animator.enabled = false;
        //open = false;
        //anim = GetComponent<Animation>();
        //player = GameObject.FindGameObjectWithTag("Player");
        //doorObject = GameObject.FindGameObjectWithTag("Door");
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public bool openDoor()
    {
        if (openable == true && open == false && playerInventory.inventory.FindItem(itemNeeded) == true)
        {
            Debug.Log("Validation Passed From DoorIteraction");
            open = true;
            inventory.RemoveItem(itemNeeded);
        }
        else
        {
            open = false;
        }

        return open;
    }

        //if (Vector2.Distance(player.transform.position, doorObject.transform.position) < distance)
        //{
        //    Debug.Log("Door open function");
        //    if (open == false)
        //    {
        //        animator.enabled = true;
        //        animator.Play(doorOpen.name);
        //        open = true;
        //        return;
        //    }
        //    if (open == true)
        //    {
        //        animator.enabled = true;
        //        animator.Play(doorClose.name);
        //        open = false;
        //        return;
        //    }
            //if (open == true)
            //{
            //    animator.Play(doorClose.name);
            //    open = false;
            //}

            //TODO: Play animation open door

        //}
 
}
