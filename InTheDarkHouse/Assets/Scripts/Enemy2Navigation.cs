using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Navigation : MonoBehaviour {

    //private UnityEngine.AI.NavMeshAgent nav;
    public GameObject player;
    public GameObject deathCamera;
    //public LightPlaying light;
    public float speed;

    public AudioSource audioSource;
    public AudioClip clip1;
    public AudioClip clip2;


    public float distance;
    public bool run = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //CurrentNavigation.target = transform.position;
    }

    void Update()
    {
        if (player.GetComponent<PlayerScript>().lightPicked == false)
        {
            if (run == false)
            {
                
                audioSource.clip = clip2;
                audioSource.enabled = true;
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), player.transform.position, speed * Time.deltaTime);
            }

            if (player.transform.position == this.transform.position)
            {
                //dead

                player.SetActive(false);
                deathCamera.SetActive(true);
            }
            
        }

        if (Vector2.Distance(player.transform.position, this.transform.position) < distance && player.GetComponent<PlayerScript>().lightPicked == true)
        {
            audioSource.clip = clip1;
            audioSource.enabled = true;
            distance = 1.5f;
            //enemyAnimator.enabled = true;
            //enemyAnimator.Play(enemyAnimation.name);
            if (run == true)
            {
                switch (Random.Range(1, 3))
                {
                    case 1:
                        Debug.Log("Random = 1");
                        this.transform.position += Vector3.left * speed * Time.deltaTime;
                        break;
                    case 2:
                        Debug.Log("Random = 2");
                        this.transform.position += Vector3.down * speed * Time.deltaTime;
                        break;
                    case 3:
                        Debug.Log("Random = 3");
                        this.transform.position += Vector3.right * speed * Time.deltaTime;
                        break;

                }
            }
           
            //this.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        //if (light.picked == false)
        //{
        //    Debug.Log("Light picked = false");
        //    transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), player.transform.position, speed * Time.deltaTime);
        //}
        //if (light.picked == true)
        //{
        //    Debug.Log("Light picked = true");
        //    transform.position = new Vector2(transform.position.x, transform.position.y);
        //}

    }

    public void moveEnemy(bool lightPicked)
    {
        //while (lightPicked == true)
        //{
        //    transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), player.transform.position, speed * Time.deltaTime);
        //}
    }
}
