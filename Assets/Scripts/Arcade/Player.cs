using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int acceleration = 1;
    public int maxvely = 100;
    public int playervel = 25;
    Rigidbody rb;
    bool left = false;
    bool up = false;
    private int score = 0;
    public Text scoreText;
    public AudioManager AM;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(AM.Play("ArcadeSong", 1, .001f));
    }

    private void Update()
    {
        scoreText.text = "Score: " + score;
        if (Input.GetMouseButton(0))
        {
            if(Input.mousePosition.x > Screen.width*2 / 3)
            {
                if(left)
                {
                    rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
                }
                
                rb.AddForce(new Vector3(playervel, 0, 0));
                left = false;
            }
            else if(Input.mousePosition.x < Screen.width / 3)
            {
                if(!left)
                {
                    rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
                }
                rb.AddForce(new Vector3(-playervel, 0, 0));
                left = true;
            }
            //Up Down
            if (Input.mousePosition.y > Screen.height * 2/ 3)
            {
                if (up)
                {
                    rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
                }

                rb.AddForce(new Vector3(0, 0, -playervel));
                up = false;
            }
            else if (Input.mousePosition.y < Screen.height / 3)
            {
                if (!up)
                {
                    rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
                }
                rb.AddForce(new Vector3(0, 0, playervel));
                up = true;
            }
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x > Screen.width * 2 / 3)
            {
                if (left)
                {
                    rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
                }

                rb.AddForce(new Vector3(playervel, 0, 0));
                left = false;
            }
            else if (touch.position.x < Screen.width / 3)
            {
                if (!left)
                {
                    rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
                }
                rb.AddForce(new Vector3(-playervel, 0, 0));
                left = true;
            }
            //Up Down
            if (touch.position.y > Screen.height * 2 / 3)
            {
                if (up)
                {
                    rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
                }

                rb.AddForce(new Vector3(0, 0, -playervel));
                up = false;
            }
            else if (touch.position.y < Screen.height / 3)
            {
                if (!up)
                {
                    rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
                }
                rb.AddForce(new Vector3(0, 0, playervel));
                up = true;
            }
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(0,10,0));
        if (rb.velocity.y > maxvely)
        {
            rb.velocity = new Vector3(rb.velocity.x, maxvely, rb.velocity.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Kill")
        {
            Destroy(this.gameObject);
        }
        if (other.tag == "Good")
        {
            other.gameObject.transform.parent.gameObject.SetActive(false);
            score++;
        }
    }
}
