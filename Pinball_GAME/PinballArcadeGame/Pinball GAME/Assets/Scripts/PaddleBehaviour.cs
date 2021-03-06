using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBehaviour : MonoBehaviour
{
    public float paddleSpd;
    private Rigidbody2D paddleRgd;
    public bool isLeft;
   
    void Start()
    {
        paddleRgd = this.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        MovePaddle();
    }

    private void MovePaddle()
    {
        if (isLeft)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                paddleRgd.angularVelocity += paddleSpd;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                paddleRgd.angularVelocity -= paddleSpd;
            }
        }
    }
}
