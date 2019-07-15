using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour
{

    //variables to hold various objects
    private float fillAmount;

    [SerializeField]
    private Image bar;

    [SerializeField]
    private Text valText;

    [SerializeField]
    private float lerpSpeed;

    public float max { get; set; }

    public float value
    {
        //text for inside bars
        set
        {
            string[] temp = valText.text.Split(':');
            valText.text = temp[0] + ": " + value;
            fillAmount = Map(value, 0, max, 0, 1);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleBar();
    }

    private void HandleBar()
    {
        //updates fillamount if it changes
        if (fillAmount != bar.fillAmount)
        {
            bar.fillAmount = Mathf.Lerp(bar.fillAmount, fillAmount, Time.deltaTime * lerpSpeed);
        }

    }
    //calculates the amount to fill bar
    private float Map(float val, float inMin, float inMax, float outMin, float outMax)
    {
        return (val - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
}
