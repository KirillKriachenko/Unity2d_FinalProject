using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaiour3 : MonoBehaviour {

    public GameObject player;
    public GameObject enemy;

    public float speed;
    public float distance;

    public List<GameObject> patrollPoints;
	// Use this for initialization
	void Start () {
        enemyPatrol();
	}

    // Update is called once per frame
    void Update()
    {
        enemyPatrol();
        //enemyPatrol();
        if (Vector2.Distance(player.transform.position, enemy.transform.position) < distance)
        {
            attackPlayer();
        }
    }

    void attackPlayer()
    {
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), player.transform.position, speed * Time.deltaTime);
    }

    void enemyPatrol()
    {
        for (int i = 0; i < patrollPoints.Count; i++)
        {

            Debug.Log("List entered");
            if (i != 0 && i != patrollPoints.Count)
            {
                switch (Random.Range(1, 2))
                {
                    case 1:
                        Debug.Log("CASE 1");
                        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), patrollPoints[i - 1].transform.position, speed * Time.deltaTime);
                        Debug.Log(patrollPoints[i].name);
                        break;
                    case 2:
                        Debug.Log("CASE 1");
                        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), patrollPoints[i + 1].transform.position, speed * Time.deltaTime);
                        Debug.Log(patrollPoints[i].name);
                        break;

                }

                break;
            }

            if (i == 0 && enemy.transform.position != patrollPoints[i + 1].transform.position)
            {
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), patrollPoints[i + 1].transform.position, speed * Time.deltaTime);
                Debug.Log(patrollPoints[i].name + "This IS 0");
                break;
            }

            if (i == patrollPoints.Count)
            {
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), patrollPoints[i - 1].transform.position, speed * Time.deltaTime);
                Debug.Log(patrollPoints[i].name + "This IS LAST");
                break;
            }


            Update();
        }
    }
}
