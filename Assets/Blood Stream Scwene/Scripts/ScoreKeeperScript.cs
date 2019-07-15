using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeperScript : MonoBehaviour
{
    //score keeper script

        //initializing variables
    private int score;     public Text scoreText; 
     void Start()     {
        //set score to 0         score = 0;         updateScore();     }      public void AddScore(int newScoreValue)     {
        //add new value to score         score += newScoreValue;         updateScore();     }      //update the score     void updateScore()
    {         scoreText.text = "Score: " + score;
    }   
}
