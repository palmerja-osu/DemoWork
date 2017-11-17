using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour {

    public GameObject ui;
    public Options_Menu Options_Menu;

    

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
