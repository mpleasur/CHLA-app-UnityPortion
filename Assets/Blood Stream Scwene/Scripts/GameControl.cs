using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    //variable intilization
    private int score;
    private int carbsNum;
    private int sugarNum;
    private int fatNum;
    private int fiberNum;
    private int caloriesNum;

    //make these available in the editor
    [SerializeField]
    private Stat calories;

    [SerializeField]
    private Stat carbs;

    [SerializeField]
    private Stat fiber;

    [SerializeField]
    private Stat sugar;

    //if awake
    private void Awake()
    {
        //intialize variables
        calories.Intialize();
        carbs.Intialize();
        fiber.Intialize();
        sugar.Intialize();

    }



    //set all to zero
    void Start()
    {
        score = 0;
        carbsNum = 0;
        sugarNum = 0;
        fatNum = 0;
        fiberNum = 0;
        caloriesNum = 0;
        //updateScore();

    }

   // public void AddScore(int newScoreValue)
    //{
   //     score += newScoreValue;
   //    updateScore();
   // }




     //these functions below all are public to allow for public access to change the variable amounts - these are all adding functions



    public void AddFat(int newFat)
    {
        fatNum += newFat;

    }

    public void AddCalories(int newCal)
    {
        caloriesNum += newCal;
        calories.CurrentVal = caloriesNum;
       
    }

    public void AddFiber(int newFib) 
    {
        fiberNum += newFib;
        fiber.CurrentVal = fiberNum;
       
    }

    public void AddCarbs(int newCarb)
    {
        carbsNum += newCarb;
        carbs.CurrentVal = carbsNum;
    }

    public void AddSugar(int newSug) 
    {
        sugarNum += newSug;
        sugar.CurrentVal = sugarNum;

    }

    //subtract functions
    //subtract the values removed from the plate...

    public void subFat(int newFat)
    {
        fatNum = fatNum - newFat; 

    }

    public void subCalories(int newCal)
    {
        caloriesNum = caloriesNum - newCal;
        calories.CurrentVal = caloriesNum;

    }

    public void subFiber(int newFib)
    {
        fiberNum = fiberNum - newFib;
        fiber.CurrentVal = fiberNum;

    }

    public void subCarbs(int newCarb)
    {
        carbsNum = carbsNum - newCarb;
        carbs.CurrentVal = carbsNum;

    }

    public void subSugar(int newSug)
    {
        sugarNum = sugarNum - newSug;
        sugar.CurrentVal = sugarNum;

    }















  








    //void updateScore()
    //
    //    scoreText.text = "Score: " + score;
    //}
}
