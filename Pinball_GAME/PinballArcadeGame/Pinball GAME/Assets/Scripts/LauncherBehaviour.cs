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

    private void Start()
    {
        power = 0;
        rgdBody = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (onLaunch)
        {
            launchSpring();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject.name);
        if (collision.gameObject.name == "Launch Pad")
        {
            onLaunch = true;
            rgdBody.gravityScale = 1;
        }
        if (collision.gameObject.name == "Launch Limit")
        {
            rgdBody.gravityScale = 300;
        }
    }

    private void launchSpring()
    {
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

    public float getPower()
    {
        return power;
    }
}
