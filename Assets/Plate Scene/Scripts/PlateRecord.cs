using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlateRecord : MonoBehaviour
{
   // public Text sugarText;   // public Text carbText;    // public Text caloriesText;   // public Text fiberText;    // public GameObject plate;    public GameControl nutrientControl;


     //variables to hold amounts     int sugar = 0;     int carbs = 0;     int fiber = 0;     int calories = 0;     int fat = 0; 
    //doesnt destroy     private void Awake()     {         DontDestroyOnLoad(transform.gameObject);     }     // public void setCountText()     //{     //    sugarText.text = "Sugar: " + sugar.ToString() + "g";     //    carbText.text = "Carb: " + carbs.ToString() + "g";     //    caloriesText.text = "Calories: " + calories.ToString() + "g";     //    fiberText.text = "Fiber: " + fiber.ToString() + "g";    // }


        //if there is a collision of 2d colliders - ie when the food is moved onto the plate     private void OnTriggerEnter2D(Collider2D collision)     {
        //my attempt to fix the issue see Reliable on trigger exit script
        ReliableOnTriggerExit.NotifyTriggerEnter2D(collision, gameObject, OnTriggerExit2D);

        //same for each food below - just adds the correct number to the corresponding varialbe and then adds it to the nutrient control GameControl object         if (collision.gameObject.name == "banana")         {             calories = calories + 105;             carbs = carbs + 27;             fiber = fiber + 3;             sugar = sugar + 14;             fat = fat + 0; 
            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);


            //Debug.Log(calories);         }         if (collision.gameObject.name == "broccoli")         {             calories = calories + 34;             carbs = carbs + 7;             fiber = fiber + 0;             sugar = sugar + 2;             fat = fat + 0;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }


        if (collision.gameObject.name == "beansAndRice")
        {
            calories = calories + 221;
            carbs = carbs + 86;
            fiber = fiber + 9;
            sugar = sugar + 2;
            fat = fat + 3;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);

        }         if (collision.gameObject.name == "burger")         {             calories = calories + 300;             carbs = carbs + 33;             fiber = fiber + 2;             sugar = sugar + 7;             fat = fat + 12;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "candy")         {             calories = calories + 280;             carbs = carbs + 35;             fiber = fiber + 0;             sugar = sugar + 29;             fat = fat + 14;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "carrot")         {             calories = calories + 41;             carbs = carbs + 10;             fiber = fiber + 3;             sugar = sugar + 5;             fat = fat + 0;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "cheese")         {             calories = calories + 62;             carbs = carbs + 2;             fiber = fiber + 0;             sugar = sugar + 1;             fat = fat + 5;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "chicken")         {             calories = calories + 220;             carbs = carbs + 0;             fiber = fiber + 0;             sugar = sugar + 0;             fat = fat + 24;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "chickenNuggets")         {             calories = calories + 480;             carbs = carbs + 24;             fiber = fiber + 0;             sugar = sugar + 0;             fat = fat + 32;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "chips")         {             calories = calories + 274;             carbs = carbs + 25;             fiber = fiber + 0;             sugar = sugar + 0;             fat = fat + 19;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "cookie")         {             calories = calories + 120;             carbs = carbs + 23;             fiber = fiber + 0;             sugar = sugar + 14;             fat = fat + 4;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
            Debug.Log("These are the calories: " + calories);
         }         if (collision.gameObject.name == "cupcake")         {             calories = calories + 240;             carbs = carbs + 35;             fiber = fiber + 0;             sugar = sugar + 26;             fat = fat + 10;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "donut")         {             calories = calories + 280;             carbs = carbs + 31;             fiber = fiber + 1;             sugar = sugar + 13;             fat = fat + 15;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "egg")         {             calories = calories + 78;             carbs = carbs + 0;             fiber = fiber + 0;             sugar = sugar + 0;             fat = fat + 5;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "frappucino")         {             calories = calories + 420;             carbs = carbs + 67;             fiber = fiber + 0;             sugar = sugar + 66;             fat = fat + 15;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "fries")         {             calories = calories + 378;             carbs = carbs + 50;             fiber = fiber + 5;             sugar = sugar + 0;             fat = fat + 18;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "hotdog")         {             calories = calories + 316;             carbs = carbs + 31;             fiber = fiber + 0;             sugar = sugar + 7;             fat = fat + 16;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "ice_cream")         {             calories = calories + 590;             carbs = carbs + 79;             fiber = fiber + 0;             sugar = sugar + 61;             fat = fat + 26;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "pasta")         {             calories = calories + 131;             carbs = carbs + 25;             fiber = fiber + 0;             sugar = sugar + 0;             fat = fat + 1;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "pizza")         {             calories = calories + 272;             carbs = carbs + 34;             fiber = fiber + 0;             sugar = sugar + 0;             fat = fat + 10;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "potatoes")         {             calories = calories + 180;             carbs = carbs + 23;             fiber = fiber + 2;             sugar = sugar + 2;             fat = fat + 9;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "salad")         {             calories = calories + 148;             carbs = carbs + 7;             fiber = fiber + 0;             sugar = sugar + 3;             fat = fat + 13;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "soda")         {             calories = calories + 150;             carbs = carbs + 39;             fiber = fiber + 0;             sugar = sugar + 39;             fat = fat + 0;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "steak")         {             calories = calories + 207;             carbs = carbs + 0;             fiber = fiber + 0;             sugar = sugar + 0;             fat = fat + 12;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "sandwhich")         {             calories = calories + 419;             carbs = carbs + 42;             fiber = fiber + 0;             sugar = sugar + 5;             fat = fat + 21;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "sweetpotato")         {             calories = calories + 112;             carbs = carbs + 26;             fiber = fiber + 4;             sugar = sugar + 5;             fat = fat + 0;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }
         if (collision.gameObject.name == "taco")         {             calories = calories + 157;             carbs = carbs + 14;             fiber = fiber + 3;             sugar = sugar + 0;             fat = fat + 9;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "tamale")         {             calories = calories + 284;             carbs = carbs + 34;             fiber = fiber + 3;             sugar = sugar + 0;             fat = fat + 9;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "whitebread")         {             calories = calories + 79;             carbs = carbs + 15;             fiber = fiber + 0;             sugar = sugar + 2;             fat = fat + 0;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         }         if (collision.gameObject.name == "wholegrainbread")         {             calories = calories + 69;             carbs = carbs + 12;             fiber = fiber + 2;             sugar = sugar + 2;             fat = fat + 1;

            nutrientControl.AddCalories(calories);
            nutrientControl.AddCarbs(carbs);
            nutrientControl.AddFiber(fiber);
            nutrientControl.AddSugar(sugar);
            nutrientControl.AddFat(fat);
         } 
        //debug to check calories were added         Debug.Log("These are the calories: " + calories);        //setCountText();     } 
    //when the food is moved off the plate     private void OnTriggerExit2D(Collider2D collision)     {
        //my attempt again to fix bug
        ReliableOnTriggerExit.NotifyTriggerExit(collision, gameObject);


        //same as above but subtraction         if (collision.gameObject.name == "banana")         {             calories = calories - 105;             carbs = carbs - 27;             fiber = fiber - 3;             sugar = sugar - 14;             fat = fat - 0;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);

         }         if (collision.gameObject.name == "broccoli")         {             calories = calories - 34;             carbs = carbs - 7;             fiber = fiber - 0;             sugar = sugar - 2;             fat = fat - 0;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "burger")         {             calories = calories - 300;             carbs = carbs - 33;             fiber = fiber - 2;             sugar = sugar - 7;             fat = fat - 12;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "candy")         {             calories = calories - 280;             carbs = carbs - 35;             fiber = fiber - 0;             sugar = sugar - 29;             fat = fat - 14;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "carrot")         {             calories = calories - 41;             carbs = carbs - 10;             fiber = fiber - 3;             sugar = sugar - 5;             fat = fat - 0;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "cheese")         {             calories = calories - 62;             carbs = carbs - 2;             fiber = fiber - 0;             sugar = sugar - 1;             fat = fat - 5;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "chicken")         {             calories = calories - 220;             carbs = carbs - 0;             fiber = fiber - 0;             sugar = sugar - 0;             fat = fat - 24;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "chickenNuggets")         {             calories = calories - 480;             carbs = carbs - 24;             fiber = fiber - 0;             sugar = sugar - 0;             fat = fat - 32;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }

        if (collision.gameObject.name == "beansAndRice")
        {
            calories = calories - 221;
            carbs = carbs - 86;
            fiber = fiber - 9;
            sugar = sugar - 2;
            fat = fat - 3;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);

        }
         if (collision.gameObject.name == "chips")         {             calories = calories - 274;             carbs = carbs - 25;             fiber = fiber - 0;             sugar = sugar - 0;             fat = fat - 19;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "cookie")         {             calories = calories - 120;             carbs = carbs - 23;             fiber = fiber - 0;             sugar = sugar - 14;             fat = fat - 4;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "cupcake")         {             calories = calories - 240;             carbs = carbs - 35;             fiber = fiber - 0;             sugar = sugar - 26;             fat = fat - 10;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "donut")         {             calories = calories - 280;             carbs = carbs - 31;             fiber = fiber - 1;             sugar = sugar - 13;             fat = fat - 15;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "egg")         {             calories = calories - 78;             carbs = carbs - 0;             fiber = fiber - 0;             sugar = sugar - 0;             fat = fat - 5;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "frappucino")         {             calories = calories - 420;             carbs = carbs - 67;             fiber = fiber - 0;             sugar = sugar - 66;             fat = fat - 15;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "fries")         {             calories = calories - 378;             carbs = carbs - 50;             fiber = fiber - 5;             sugar = sugar - 0;             fat = fat - 18;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "hotdog")         {             calories = calories - 316;             carbs = carbs - 31;             fiber = fiber - 0;             sugar = sugar - 7;             fat = fat - 16;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "ice_cream")         {             calories = calories - 590;             carbs = carbs - 79;             fiber = fiber - 0;             sugar = sugar - 61;             fat = fat - 26;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "pasta")         {             calories = calories - 131;             carbs = carbs - 25;             fiber = fiber - 0;             sugar = sugar - 0;             fat = fat - 1;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "pizza")         {             calories = calories - 272;             carbs = carbs - 34;             fiber = fiber - 0;             sugar = sugar - 0;             fat = fat - 10;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "potatoes")         {             calories = calories - 180;             carbs = carbs - 23;             fiber = fiber - 2;             sugar = sugar - 2;             fat = fat - 9;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "salad")         {             calories = calories - 148;             carbs = carbs - 7;             fiber = fiber - 0;             sugar = sugar - 3;             fat = fat - 13;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "soda")         {             calories = calories - 150;             carbs = carbs - 39;             fiber = fiber - 0;             sugar = sugar - 39;             fat = fat - 0;


            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }
         if (collision.gameObject.name == "steak")         {             calories = calories - 207;             carbs = carbs - 0;             fiber = fiber - 0;             sugar = sugar - 0;             fat = fat - 12;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "sandwhich")         {             calories = calories - 419;             carbs = carbs - 42;             fiber = fiber - 0;             sugar = sugar - 5;             fat = fat - 21;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "sweetpotato")         {             calories = calories - 112;             carbs = carbs - 26;             fiber = fiber - 4;             sugar = sugar - 5;             fat = fat - 0;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "taco")         {             calories = calories - 157;             carbs = carbs - 14;             fiber = fiber - 3;             sugar = sugar - 0;             fat = fat - 9;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "tamale")         {             calories = calories - 284;             carbs = carbs - 34;             fiber = fiber - 3;             sugar = sugar - 0;             fat = fat - 9;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "whitebread")         {             calories = calories - 79;             carbs = carbs - 15;             fiber = fiber - 0;             sugar = sugar - 2;             fat = fat - 0;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
         }         if (collision.gameObject.name == "wholegrainbread")         {             calories = calories - 69;             carbs = carbs - 12;             fiber = fiber - 2;             sugar = sugar - 2;             fat = fat - 1;

            nutrientControl.subCalories(calories);
            nutrientControl.subCarbs(carbs);
            nutrientControl.subFiber(fiber);
            nutrientControl.subSugar(sugar);
            nutrientControl.subFat(fat);
          }
        //checks if they were subtracted in log         Debug.Log("These are the calories: " + calories);         //setCountText();      } 
    //checks what starting is      void Start()     {         Debug.Log(calories);         //setCountText();     }
}
