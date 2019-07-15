using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//public class for changing value/fill amount of bar
[Serializable]
public class Stat
{
    [SerializeField]
    private BarScript bar;
    [SerializeField]
    private float max;
    [SerializeField]
    private float currentVal;

    public float CurrentVal
    {
        get
        {
            return currentVal;
        }

        set
        {
         //makes it so it cant go above or below  
            this.currentVal = Mathf.Clamp(value, 0, Max);
            bar.value = currentVal;
        }
    }

    public float Max
    {
        get
        {
            return max;
        }
        set
        {
            this.max = value;
            bar.max = max; 
        }
    }

    public void Intialize()
    {
        this.Max = max;
        this.CurrentVal = currentVal;
    }
}
