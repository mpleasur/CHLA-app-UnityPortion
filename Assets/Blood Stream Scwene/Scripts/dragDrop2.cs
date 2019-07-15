using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragDrop2 : MonoBehaviour
{
    //intializing variables
    private bool selected;
    //int count = 1;
    //public GameObject myModalWindow;

    
    //update function
    private void Update()
    {
        //if selected equals true
        if (selected == true)
        {
            //track cursor/finger position
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //bring it to that point - drag effect
            transform.position = new Vector2(cursorPos.x, cursorPos.y);
            //count = count + 1;
        }
        //when finger or mouse is up 
        if (Input.GetMouseButtonUp(0))
        {
            selected = false;
        }
    }

    //if clicked on
    private void OnMouseOver()
    {
        //change selected to true
        if (Input.GetMouseButtonDown(0))
        {
            selected = true;
           // if (count == 1)
           // {
           //    myModalWindow.SetActive(true);

           // }
            //myModalWindow.SetActive(true);
        }
    }
}
