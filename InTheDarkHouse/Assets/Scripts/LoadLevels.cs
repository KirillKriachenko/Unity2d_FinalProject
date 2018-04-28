using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered enter");
        if (other.tag == "Player" && this.name == "LoadLevel2")
        {
            SceneManager.LoadScene("Level2");
        }

        if (other.tag == "Player" && this.name == "Load1-2")
        {
            SceneManager.LoadScene("Level2-1");
        }

        if (other.tag == "Player" && this.name == "Load2-1")
        {
            SceneManager.LoadScene("Level2-1");
        }

        if (other.tag == "Player" && this.name == "LoadLevel3")
        {
            SceneManager.LoadScene("Level3"); // here should load level 3
        }

        if (other.tag == "Player" && this.name == "LoadLevel3-1")
        {
            SceneManager.LoadScene("Level3-1");
        }
    }
}
