using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public int score;
    public Text txt;

    private void Start()
    {
        score = 0;
    }


    private void Update()
    {

        
        txt.GetComponent<Text>().text = "Score: " + score.ToString();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //checks the object for a tag, and assigns points based on tag
        if (other.gameObject.tag == "Green") score += 20;
        if (other.gameObject.tag == "red") score += 10;
        if (other.gameObject.tag == "winbox") score += 50;

        //on hitting the out of bounds at the bottom of the pinball machine, it resets your position velocity and score
        if (other.gameObject.tag == "lossbox")
        {
            this.GetComponent<Rigidbody2D>().position = new Vector3(3.75f, -2.5f, 0.0f);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 0.0f);
            score = 0;
        }
    }
}
