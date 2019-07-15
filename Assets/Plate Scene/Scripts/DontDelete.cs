using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDelete : MonoBehaviour
{
    //don't destroy script
    void Awake()     {         DontDestroyOnLoad(transform.gameObject);     }  
}
