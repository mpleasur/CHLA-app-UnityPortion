using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockKey : MonoBehaviour
{
    //check for collison
    private void OnTriggerEnter2D(Collider2D collision)     {
        //object has tag key         if (collision.gameObject.tag == "key")         {
            //hide the sprite             GetComponent<SpriteRenderer>().enabled = false;             GetComponent<Collider2D>().enabled = false;         }
        //start a coroutine so wait for lock to reactivate         StartCoroutine("Lock");     }
     //unlockAllKeys unclocks all keys - used in metformin and exerise power ups     public void unlockAllKeys()     {         GetComponent<SpriteRenderer>().enabled = false;         GetComponent<Collider2D>().enabled = false;         StartCoroutine("Lock");     } 
    //coroutine     IEnumerator Lock()     {

        //wait to reactivate/show sprite         for (; ; )         {             yield return new WaitForSecondsRealtime(10);             GetComponent<SpriteRenderer>().enabled = true;             GetComponent<Collider2D>().enabled = true;         }     }   
}
