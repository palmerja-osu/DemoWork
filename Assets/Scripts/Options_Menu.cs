using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Options_Menu : MonoBehaviour {

    [Header("Connecting Panels")]

    //public Menu Menu;
    public ChangeImages changeImage;
    public Panel_Freq Panel_Freq;
    public Panel_Gain Panel_Gain;
    public Keypad_RotCode Keypad_RotCode;
    public Small_PlaneToggle SmallPlaneToggle;
    public Store_Button Store_Button;
    


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
    //     Change main image //  Channel
    //***************************************

    public void PressedChannelButton()
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
    //functionality for second scene
    public void FrequencyButton2()
    {
        SmallPlaneToggle.Toggle();
        Panel_Freq.Update();
        Debug.Log("Frequency2 button");
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

    public void GainButton2()
    {
        Panel_Gain.Update();
        Debug.Log("Gain button");
    }

    private void ToggleGainMenu()
    {
        Toggle();
        Panel_Gain.Update();
    }

    //***************************************
    //      Store // Screenshot 
    //***************************************
    public void StoreButton()
    {
        //Store_Button.Start();
        Debug.Log("Store button");
    }


    //***************************************
    //      Rotation
    //***************************************

    public void rotOutput(string rotOut)
    {
        
        rotationOutput = rotOut;
        //take string and output
        rotationText.GetComponent<Text>().text = "Rotation: " + rotationOutput + " Deg";
    
    }
    public void RotationButton()
    {
        ToggleRotation();
        
        Debug.Log("Open Rotation button");
    }
    public void RotationButton2()
    {
        Keypad_RotCode.Update();
        SmallPlaneToggle.Toggle();
        Debug.Log("Open Rotation button");
    }
    private void ToggleRotation()
    {
        Toggle();
        Keypad_RotCode.Update();
    }

    //***************************************
    //     Clear Button
    //***************************************
    public void PressedClearButton()
    {

        changeImage.ClearButtonimgCount();
        Debug.Log("pressed clear button");
    }

    //***************************************
    //     Change Display Layout
    //***************************************
    
    public void PressedDisplayButton()
    {
        SceneManager.LoadScene("pt2_Touch");
    }

    public void PressedReturnDisplayButton()
    {
        SceneManager.LoadScene("touchscreen demo");
    }



    public void Toggle()
    {

        //incase its enabled, flipped and set inactive and visa versa
        ui.SetActive(!ui.activeSelf);


    }
}
