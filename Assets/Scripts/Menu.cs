using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour {

    public GameObject ui;
    public Options_Menu Options_Menu;


    //possible touch input recon
    //in void update
    //void Update()
    //{
    //    //touch on screen? 
    //    if(Input.touches.Length <= 0)
    //    {
    //        //no touches then do this
    //    }
    //    else //if touch exists
    //    {
    //        //exectues this code for current touch (i)
    //        for (int i = 0; i < Input.touchCount; i++)
    //        {
    //            if (this.guiTexture.HitTest(Input.GetTouch(i).position))
    //            {
    //                //if current touch hits our guitexture, run this
    //                if(Input.GetTouch(i).phase == TouchPhase.Began)
    //                {
    //                    Debug.Log("The touch is down on" + this.name);
    //                }
    //                if(Input.GetTouch(i).phase == TouchPhase.Ended)
    //                {
    //                    Debug.Log("The Touch has ended on " + this.name");
    //                }
    //            }
    //        }
    //}
    

    public void Update()
    {
        // Check if there is a touch
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //touch screen
            if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
            {
                Debug.Log("Touched the menu UI");
            }
        }


    }

   


    public void PressedMenuButton()
    {
        Toggle();

        //toggle options menu 
        ToggleNewMenu();
        
        
        Debug.Log("pressed menu button");
    }

    private void ToggleNewMenu()
    {
        Options_Menu.Update();
    }

    public void Toggle()
    {
        //incase its enabled, flipped and set inactive and visa versa
        ui.SetActive(!ui.activeSelf);

      
    }
}
