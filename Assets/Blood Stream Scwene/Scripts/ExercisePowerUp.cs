using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercisePowerUp : MonoBehaviour
{
    //variable intialization
    private bool selected;      public UnlockKey key1;     public UnlockKey key2;     public UnlockKey key3;     public UnlockKey key4;     public UnlockKey key5;     public UnlockKey key6;        //if the exercise power up is clicked     private void OnMouseOver()     {         if (Input.GetMouseButtonDown(0))         {
            //hide the sprite             selected = true;             GetComponent<SpriteRenderer>().enabled = false;             GetComponent<Collider2D>().enabled = false;         }
        //unlock all the keys         key1.unlockAllKeys();         key2.unlockAllKeys();         key3.unlockAllKeys();         key4.unlockAllKeys();         key5.unlockAllKeys();         key6.unlockAllKeys();        
        //start coroutine         StartCoroutine("wait");     }  
    //coroutine to wait      IEnumerator wait()     {         for (; ; )         {
            //show the sprite after 25 seconds             yield return new WaitForSecondsRealtime(25);             GetComponent<SpriteRenderer>().enabled = true;             GetComponent<Collider2D>().enabled = true;         }     } 
}
