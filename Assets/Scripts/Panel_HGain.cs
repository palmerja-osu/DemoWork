using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Panel_HGain : MonoBehaviour
{

    public GameObject ui;
    public GameObject PanelH_MenuUI;
    public Options_Menu Options_Menu;


    public void Update()
    {
        //open inspector when menu button is pressed
        PanelH_MenuUI.SetActive(true);

    }

    public void exitButton()
    {
        Toggle();
        returnToOptions();
        Debug.Log("pressed exit button");
    }

    private void returnToOptions()
    {

        Options_Menu.Update();
    }


    public void Toggle()
    {

        //incase its enabled, flipped and set inactive and visa versa
        ui.SetActive(!ui.activeSelf);

    }
}
