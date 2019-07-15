using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeftScript : MonoBehaviour
{
    //intializing variables
    Text text;
    public GameObject modalWindow;     public static float timeLeft = 45f;
    public ScoreKeeper scoreKeep;      // Start is called before the first frame update     void Start()     {
        //star the time left value         text = GetComponent<Text>() ;
        timeLeft = 45f;
        modalWindow.SetActive(false);
    }      // Update is called once per frame     void Update()     {
        //update the time to lose one second each second         timeLeft -= Time.deltaTime;         if (timeLeft < 0)         {             timeLeft = 0;
            modalWindow.SetActive(true);
            scoreKeep.AddScore(0);
            scoreKeep.printScore();
         }
        //update the time left text         text.text = "Time left: " + Mathf.Round(timeLeft);     } 
}
