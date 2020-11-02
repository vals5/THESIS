using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public Text highScore;
    public static int scoreAmount;

    void Start()
    {
        score = GetComponent<Text>();
        scoreAmount = 0;
        highScore.text = $"HIGH SCORE: {PlayerPrefs.GetInt("HighScore", 0)}";
    }
    void Update()
    {
        score.text = "SCORE: " + scoreAmount;

        if(scoreAmount > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scoreAmount);
            highScore.text = $"HIGH SCORE: {scoreAmount}";
        }
    }    
}
