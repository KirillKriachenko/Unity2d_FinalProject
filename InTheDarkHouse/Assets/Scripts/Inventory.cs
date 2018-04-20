using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    //public Image[] itemImages = new Image[numItemSlots];
    public Texture[] items = new Texture[numItemSlots];
    public const int numItemSlots = 4;
    private bool foundItem;
    public void AddItem(Texture itemToAdd)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = itemToAdd;
                //itemImages[i].sprite = itemToAdd.sprite;
                //itemImages[i].enabled = true;
                return;
            }
        }
    }
    public void RemoveItem(Texture itemToRemove)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemToRemove)
            {
                Debug.Log(items[i].name + "found");
                items[i] = null;
                //itemImages[i].sprite = null;
                //itemImages[i].enabled = false;
                Debug.Log( "Removed!");
                return;
            }
        }
    }

    public bool FindItem(Texture itemToFind)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemToFind)
            {
                foundItem = true;
            }
        }

        return foundItem;
    }

    void OnGUI()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (GUI.Button(new Rect((Screen.width / 2 - 190) + i * 100,Screen.height-100, 50, 50), items[i]))
            {

            }

        }
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        if (GUI.Button(new Rect(i * 100, j * 100, 100, 100), items[items[j * 5 + i]]))
        //        {

        //        }
        //    }
        //}
    }
                //public int[] items;
                //public int moustSlot;
                //public Lib lib;


                //private float startPointX = Screen.width / 2-100;
                //private float startPointY = Screen.height / 2-100;

                //public void AddItem(Lib itemToAdd)
                //{
                //    for (int i = 0; i < items.Length; i++)
                //    {
                //        if (items[i] == null)
                //        {
                //            items[i] = itemToAdd;
                //        }
                //    }
                //}

                //void OnGUI()
                //{
                //    for (int i = 0; i < 5; i++)
                //    {
                //        for (int j = 0; j < 5; j++)
                //        {
                //            if (GUI.Button(new Rect(i*100,j*100,100,100),lib.Images[items[j*5+i]]))
                //            {

                //            }

                //        }
                //    }
                //}
            
}