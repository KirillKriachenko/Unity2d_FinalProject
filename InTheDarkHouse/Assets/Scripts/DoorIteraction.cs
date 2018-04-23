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
    // Use this for initialization
    void Start () {
        open = false;

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
}
