using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Small_PlaneToggle : MonoBehaviour {

    public GameObject ui;
    public Panel_Freq Panel_Freq;
    public Panel_Gain Panel_Gain;
    public Keypad_RotCode Keypad_RotCode;

	public void Update () {
        //open inspector when menu button is pressed
        ui.SetActive(true);
    }

    public void Toggle()
    {

        //incase its enabled, flipped and set inactive and visa versa
        ui.SetActive(!ui.activeSelf);

    }
}
