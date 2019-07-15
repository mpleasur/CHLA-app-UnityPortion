using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    //variable intialization
    private bool selected;     int count = 1;     public GameObject myModalWindow;

    //check this every frame     private void Update()     {
        //if clicked         if (selected == true)         {
            //track finger or mouse             Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);             transform.position = new Vector2(cursorPos.x, cursorPos.y);             count = count + 1;         }         //stop trackig when finger picks up         if (Input.GetMouseButtonUp(0))         {             selected = false;         }     } 
    //on mouse over     private void OnMouseOver()     {
        //if clicked         if (Input.GetMouseButtonDown(0))         {
            //sets to true              selected = true;
            //makes it so modal window only shows once             if (count == 1)             {
                myModalWindow.SetActive(true);              }
            //myModalWindow.SetActive(true);
            if (count > 1)             {                 myModalWindow.SetActive(false);             }         }     }  
}
