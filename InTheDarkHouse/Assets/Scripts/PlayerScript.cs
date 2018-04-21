using Light2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    #region Properties

    public Animator animator;

    public AnimationClip walkUp;
    public AnimationClip walkLeft;
    public AnimationClip walkDown;
    public AnimationClip walkRight;

    public Inventory inventory;

    public GameObject myLight;
    public bool lightPicked;
    public float distance;
    public Camera playerCamera;
    public GameObject textCamera;
    public float speed;

    public GameObject text;

    public GameObject objectForText;
    public bool showText;

    public Enemy2Navigation enemyScript;

    public LightPlaying lightPlaying;

    public List<GameObject> candleList;

    //public DisplayText displayText;
    private bool flag;
    private bool showTips;

    private Rigidbody2D rigidbody;

    public Texture damageTexture;
    private bool demegeText = false;

    private bool playAudioClip;


    public AudioSource audioSource;
    #endregion

    // Use this for initialization
    void Start()
    {
        //audioSourceFootStep = GetComponent<AudioSource>();

        audioSource = GetComponent<AudioSource>();

        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.enabled = false;

        //textCamera = GameObject.FindGameObjectWithTag("Cameratext");
        //textCamera = GetComponent<GameObject>();

        flag = false;
        showTips = false;

        lightPicked = false;

        showText = false;

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            audioSource.enabled = true;
            audioSource.loop = true;

            animator.enabled = true;
            animator.Play(walkLeft.name);
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            audioSource.enabled = false;
            animator.enabled = false;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            audioSource.enabled = true;
            audioSource.loop = true;

            animator.enabled = true;
            animator.Play(walkRight.name);
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            audioSource.enabled = false;
            animator.enabled = false;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            audioSource.enabled = true;
            audioSource.loop = true;

            animator.enabled = true;
            animator.Play(walkUp.name);
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            audioSource.enabled = false;
            animator.enabled = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            audioSource.enabled = true;
            audioSource.loop = true;

            animator.enabled = true;
            animator.Play(walkDown.name);
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            audioSource.enabled = false;
            animator.enabled = false;
        }


        if (Input.GetKeyUp(KeyCode.F))
        {

            for (int i = 0; i < candleList.Count; i++)
            {
                if (Vector2.Distance(this.transform.position, candleList[i].transform.position) < distance)
                {

                    myLight = GameObject.Find(candleList[i].name);
                    if (lightPicked == false)
                    {
                        if (inventory.FindItem(candleList[i].GetComponent<LightPlaying>().pickedItem) == false)
                        {
                            inventory.AddItem(candleList[i].GetComponent<LightPlaying>().pickedItem);
                        }

                        lightPicked = true;
                        enemyScript.run = true;
                        enemyScript.audioSource.enabled = false;
                        setBrightness(0.6f);
                        lightPlaying.candleH(10);

                        return;
                    }
                    if (lightPicked == true)
                    {
                        if (inventory.FindItem(candleList[i].GetComponent<LightPlaying>().pickedItem) == true)
                        {
                            inventory.RemoveItem(candleList[i].GetComponent<LightPlaying>().pickedItem);
                        }
                       
                        lightPicked = false;
                        enemyScript.run = false;
                        enemyScript.audioSource.enabled = false;
                        setBrightness(0.2f);
                    }
                }
            }
            

        }

        if (lightPicked == true)
        {
            
            myLight.GetComponent<LightPlaying>().candleH(10);
            myLight.transform.SetPositionAndRotation(this.transform.position, this.transform.rotation);
        }

        
    }
    public void setBrightness(float brightness)
    {
        myLight.GetComponent<LightSprite>().Color.a = brightness;
    }

    void OnGUI()
    {
        if (this.GetComponent<Demage>().showDamage == true)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), damageTexture);
        }
    }
}