using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tips : MonoBehaviour
{
    [TextArea]
    public string tipsText;
    public bool showTips;
    public Collider2D trigger;
    public int enterCount;
    public GameObject light;
    // Use this for initialization
    void Start()
    {
        enterCount = 0;
        showTips = false;
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            enterCount += 1;
            showTips = true;
        }
    }

    void OnGUI()
    {
        if (showTips == true && enterCount < 2)
        {
            GUI.color = Color.cyan;
            GUI.Label(new Rect(Screen.width/2 - 100, Screen.height/2, 100, 100), tipsText);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            showTips = false;
            DestroyObject(trigger);
            DestroyObject(light);
        }
    }
}
