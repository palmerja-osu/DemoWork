using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;

public class Options_Menu : MonoBehaviour {

    [Header("Connecting Panels")]

    //public Menu Menu;
    public ChangeImages changeImage;
    public Panel_Freq Panel_Freq;
    public Panel_Gain Panel_Gain;
    public Keypad_RotCode Keypad_RotCode;
    

    [Header("Options UI Toggle")]
    public GameObject ui;

    [Header("Menu Text")]
    public GameObject rotationText;
    public string rotationOutput;


    
    public void Update()
    {
        //open inspector when menu button is pressed
       ui.SetActive(true);
        
    }



    //***************************************
    //     Change main image
    //***************************************

    public void PressedDisplayButton()
    {

        changeImage.changeImages();
        Debug.Log("pressed display button");
    }


    //***************************************
    //      Frequency
    //***************************************
    public void FrequencyButton()
    {
        //frequencyText.text = "Frequency: " + OptionsStats.Frequency.ToString() + "MHz";  //could do this
        ToggleFreqMenu();
        Debug.Log("Frequency button");
    }
    //change menues
    private void ToggleFreqMenu()
    {
        Toggle();
        Panel_Freq.Update();
    }


    //***************************************
    //      Gain
    //***************************************
    public void GainButton()
    {
        ToggleGainMenu();
        Debug.Log("Gain button");
    }

    private void ToggleGainMenu()
    {
        Toggle();
        Panel_Gain.Update();
    }


    ////***************************************
    ////      V_Gain
    ////***************************************
    //public void H_GainButton()
    //{
    //    ToggleHGain();
    //    Debug.Log("Gain button");
    //}

    //private void ToggleHGain()
    //{
    //    Toggle();
    //    Panel_HGain.Update();
    //}



   

    //***************************************
    //      Rotation
    //***************************************
    
    public void rotOutput(string rotOut)
    {
        Debug.Log("rotOutPut");
        rotationOutput = rotOut;
        //take string and output
        rotationText.GetComponent<Text>().text = "Rotation: " + rotationOutput + " Deg";
    
    }
    public void RotationButton()
    {
        ToggleRotation();
        
        Debug.Log("Open Rotation button");
    }
    private void ToggleRotation()
    {
        Toggle();
        Keypad_RotCode.Update();
    }

    //***************************************
    //     Return to Menu
    //***************************************
    //public void MenuButton()
    //{
    //    ToggleMenu();
    //    Debug.Log("Menu button");
    //}
    //private void ToggleMenu()
    //{
    //    Toggle();
    //    Menu.Toggle();
    //}




    public void Toggle()
    {

        //incase its enabled, flipped and set inactive and visa versa
        ui.SetActive(!ui.activeSelf);


    }
}
