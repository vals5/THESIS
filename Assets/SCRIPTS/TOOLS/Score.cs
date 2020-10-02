using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public static int scoreAmount;

    void Start()
    {
        score = GetComponent<Text>();
        scoreAmount = 0;
    }
    void Update()
    {
        score.text = "SCORE: " + scoreAmount;
    }    
}
