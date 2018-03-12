using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Behaviour : MonoBehaviour {

    public GameObject enemyObject;
    public GameObject player;

    public Animator enemyAnimator;
    public AnimationClip enemyAnimation;

    public float distance;
    public float speed;

    // Use this for initialization
    void Start () {

        enemyAnimator = GetComponent<Animator>();
        enemyObject = GameObject.FindGameObjectWithTag("Enemy");
        player = GameObject.FindGameObjectWithTag("Player");

        enemyAnimator.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        //if (Vector2.Distance(enemyObject.transform.position,player.transform.position) < distance)
        if (Vector2.Distance(player.transform.position, enemyObject.transform.position) < distance)
        {
            distance = 1.5f;
            enemyAnimator.enabled = true;
            enemyAnimator.Play(enemyAnimation.name);
            enemyObject.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else
        {
            enemyAnimator.enabled = false;
            distance = 0.3f;
        }
	}
}
