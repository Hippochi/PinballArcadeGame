using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public int score;

    private void Start()
    {
        score = 0;
    }


    private void Update()
    {
        this.GetComponent<Text>().text = "Score: " + score.ToString();
    }
}
