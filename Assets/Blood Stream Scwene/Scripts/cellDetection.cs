using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cellDetection : MonoBehaviour
{
    //intializing variables
    private Rigidbody2D body;     //public GameObject cell;     private bool isCollidedwithCell = false;     private bool isCollidedwithLock = false;     float force = 10f;     public int scoreValue;     public ScoreKeeper scoreKeeper; 
    //start function     private void Start()     {
        //saves the rigidbody          body = GetComponent<Rigidbody2D>();     } 
    //function to check for collisions     private void OnTriggerEnter2D(Collider2D collision)     {
        //checks if the collision was a object with the tag lock         if (collision.gameObject.tag == "lock")         {             isCollidedwithLock = true;                    }
        //checks if the collision was a object with the tag cell         if (collision.gameObject.tag == "cell")         {             isCollidedwithCell = true;         }          //checks if it collided with a cell and did not collide with a lock - ie a cell without a lock          if ((isCollidedwithCell == true) && (isCollidedwithLock == false))         {
            //add 5 points to score             scoreKeeper.AddScore(scoreValue);
            //wait coroutine so lock does not reactivate             StartCoroutine("wait");         }
        //checks if it collided with a cell with a lock - ie a cell with a lock still on it         if ((isCollidedwithCell == true) && (isCollidedwithLock == true))         {
            //gets the two rigidbody components             Rigidbody2D thisBody = GetComponentInParent<Rigidbody2D>();             Rigidbody2D thatBody = collision.GetComponentInParent<Rigidbody2D>();
            //creates a  relative direction             var rel = new Vector2(thisBody.position.x, 0) - new Vector2(thatBody.position.x, 0); 
            //normalize this value             rel.Normalize();

            //multiply it by the force variable             thisBody.AddForce(rel * force);           }      }     //checks for the trigger being deactivated     private void OnTriggerExit2D(Collider2D collision)     {
        //if the object has tag lock         if (collision.gameObject.tag == "lock")          {
            //set is collided variable to false             isCollidedwithCell = false;         }
        //if the object has tag cell         if (collision.gameObject.tag == "cell")         {
            //set to is collided with false             isCollidedwithCell = false;         }      }           //coroutine function
    //waits for locks to reappear and reactivate      IEnumerator wait()     {         for (; ; )         {             body.bodyType = RigidbodyType2D.Static;             yield return new WaitForSecondsRealtime(3);                          gameObject.SetActive(false);          }     } 
    //another coroutine function     IEnumerator wait2()     {         for (; ; )         {             yield return new WaitForSecondsRealtime(5);          }     }
}
