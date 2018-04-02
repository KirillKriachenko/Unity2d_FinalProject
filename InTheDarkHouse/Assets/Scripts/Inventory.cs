using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public int[] items;
    public int moustSlot;
    public Lib lib;


    private float startPointX = Screen.width / 2-100;
    private float startPointY = Screen.height / 2-100;
    void OnGUI()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (GUI.Button(new Rect(i*100,j*100,100,100),lib.Images[items[j*5+i]]))
                {

                }
                
            }
        }
    }
}
