using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    //keeps score 


        //intializing variables
    private int score;     public Text scoreText;
    public Text finalScore;      void Start()     {
        //set score to 0         score = 0;         updateScore();     } 
    //add a value to the score - public function     public void AddScore(int newScoreValue)     {         score += newScoreValue;         updateScore();     }      //update the score text     void updateScore()
    {         scoreText.text = "Score: " + score;
    }     //print the score at the end
    public void printScore()
    {
        finalScore.text = "Final Score: " + score;
    }






}
