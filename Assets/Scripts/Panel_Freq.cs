using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Panel_Freq : MonoBehaviour {

    public GameObject ui;
    public GameObject Freq_MenuUI;
    public Options_Menu Options_Menu;
    public Small_PlaneToggle Small_PlaneToggle;


    public void Update()
    {
        //open inspector when menu button is pressed
        Freq_MenuUI.SetActive(true);

    }

    public void exitButton()
    {
        Toggle();
        returnToOptions();

        Debug.Log("pressed exit button");
    }

    //exit button for second scene
    public void exitButton2()
    {
        Toggle();
        returnToOptions();
        Small_PlaneSwitch();
        Debug.Log("pressed exit button");
    }    
    
    private void returnToOptions()
    {
        
        Options_Menu.Update();
    }

    private void Small_PlaneSwitch()
    {
        Small_PlaneToggle.Toggle();
    }

    public void Toggle()
    {

        //incase its enabled, flipped and set inactive and visa versa
        ui.SetActive(!ui.activeSelf);
        
    }
}
