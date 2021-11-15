using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE : " + theScore;
        if (theScore >= 300)
        {
            scoreText.GetComponent<Text>().text = "YOU WINNNN !!!";
        }
        else if (theScore < 0)
        {
            scoreText.GetComponent<Text>().text = "YOU LOSEEEE !!!";
        }
    }
}
