using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherBehaviour : MonoBehaviour
{
    public float powerLmt;
    public float powerSpd;
    public float power;
    private Rigidbody2D rgdBody;
    public bool onLaunch;
    public GameObject ball;

    private void Start()
    {
        power = 0;
        rgdBody = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (onLaunch)
        {
            if (ball.GetComponent<Rigidbody2D>().position.x >3.7)
            launchSpring();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       //resets the gravity at the base of the launch tunnel
        if (collision.gameObject.name == "Launch Pad")
        {
            onLaunch = true;
            rgdBody.gravityScale = 1;
        }
        //pushes it back down if it goes too high
        if (collision.gameObject.name == "Launch Limit")
        {
            rgdBody.gravityScale = 300;
        }
    }

    private void launchSpring()
    {
        //adds a set value per frame you hold w for, then upon release shoots it up at your built up power, then resets
        if (Input.GetKey(KeyCode.W))
        {
            power += powerSpd;
            if (power > powerLmt)
            {
                power = powerLmt;
            }
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            rgdBody.velocity = new Vector2(0, power);
            resetSpring();
        }
    }

    private void resetSpring()
    {
        onLaunch = false;
        power = 0;
    }

}
