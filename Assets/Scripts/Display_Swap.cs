using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display_Swap : MonoBehaviour {

    public GameObject ui;
    public NullMenu NullMenu;

    public void Update()
    {
        

        //toggle between I-planes
        ToggleImageUI();


        Debug.Log("pressed menu button");
    }

    private void ToggleImageUI()
    {
        Toggle();
        //NullMenu.PressedDisplayButton();
    }

    public void Toggle()
    {
        //incase its enabled, flipped and set inactive and visa versa
        ui.SetActive(!ui.activeSelf);


    }
}
