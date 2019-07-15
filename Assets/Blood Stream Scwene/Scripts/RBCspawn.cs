using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBCspawn : MonoBehaviour
{
   //intialize variables
    public GameObject objectToSpawn;
    public GameObject objectToSpawn2;     Vector2 whereToSpawn;     public float spawnRate = 2f;

    int randomInt; 

    //whereToSpawn = new Vector2(Random.Range(100,200), Transform.y);     float nextSpawn = 0.0f;     // Start is called before the first frame update     void Start()     {      }      // Update is called once per frame     void Update()     {
        //where to randomly spawn
        //picks a random int
        randomInt = Random.Range(0, 3);         if (Time.time > nextSpawn)         {             nextSpawn = Time.time + spawnRate;             whereToSpawn = new Vector2(transform.position.x, transform.position.y);
            if (randomInt == 0)
            {
                Instantiate(objectToSpawn, whereToSpawn, Quaternion.identity);
            }
            if (randomInt == 1)
            {
                Instantiate(objectToSpawn2, whereToSpawn, Quaternion.identity);
            }
            if (randomInt == 2)
            {
                Instantiate(objectToSpawn2, whereToSpawn, Quaternion.identity);
            }
            if (randomInt == 3)
            {
                Instantiate(objectToSpawn2, whereToSpawn, Quaternion.identity);
            }

        }      } 
}
