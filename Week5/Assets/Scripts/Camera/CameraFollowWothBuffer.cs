using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowWothBuffer : MonoBehaviour {

    public Transform playerPosition;
    public Transform playerMoveTreashold;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerPosition.position.x > playerMoveTreashold.position.x)
        {
            this.transform.position = new Vector3(playerPosition.position.x, this.transform.position.y, this.transform.position.z);
        }
	}

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(playerMoveTreashold.position, new Vector2(playerMoveTreashold.position.x, playerMoveTreashold.position.y + 50));
        Gizmos.color = Color.red;
        Gizmos.DrawLine(playerMoveTreashold.position, new Vector2(playerMoveTreashold.position.x, playerMoveTreashold.position.y - 50));
    }
}
