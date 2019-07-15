using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDelete : MonoBehaviour
{
    //deletes the key after it has collided with a lock - ie been used
    private void OnTriggerEnter2D(Collider2D collision)     {         if (collision.gameObject.tag == "lock")         {             gameObject.SetActive(false);         }

    } 
}
