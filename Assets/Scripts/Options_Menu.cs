﻿using UnityEngine;
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
    public Change_2ndImage change_2ndImage;
    public Panel_Freq Panel_Freq;
    public Panel_Gain Panel_Gain;
    public Keypad_RotCode Keypad_RotCode;
    public Small_PlaneToggle SmallPlaneToggle;
    public Store_Button Store_Button;
    public Text_Overlay Text_Overlay;
    public colorLayoutChange colorLayoutChange;
    public sceneLock sceneLock;

    // Gain Keypad
    public Keypad_XgainCode Keypad_XgainCode;
    public Keypad_YgainCode Keypad_YgainCode;

    [Header("Options UI Toggle")]
    public GameObject ui;


    [Header("Menu Text")]
    public Transform freqContent;
    public Text myFreqText;

    public Transform freqUnitContent;
    public Text myFreqUnitText;

    public Transform gainContentX;
    public Text gainTextX;

    public Transform gainContentY;
    public Text gainTextY;
    
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
    }

    public void PressedChannelButton2()
    {

        changeImage.changeImages();
        change_2ndImage.changeImages();
    }




    //***************************************
    //      Frequency
    //***************************************
    public void UpdateFreqOnFreqButton(int myPassedFreqLocation)
    {
        
        string passedText1 = freqContent.GetChild(myPassedFreqLocation).GetChild(0).gameObject.GetComponent<Text>().text;
        myFreqText.text = passedText1;
    }
    public void UpdateUnitOnFreqButton(int myPassedUnitLocation)
    {
        string passedText1 = freqUnitContent.GetChild(myPassedUnitLocation).GetChild(0).gameObject.GetComponent<Text>().text;
        myFreqUnitText.text = passedText1;
    }
    public void FrequencyButton()
    {
        ToggleFreqMenu();
        sceneLock.Toggle();
    }
    //functionality for second scene
    public void FrequencyButton2()
    {
        SmallPlaneToggle.Toggle();
        Panel_Gain.Toggle();
        Panel_Freq.Update();
        Keypad_RotCode.Toggle();
        //sceneLock.Toggle();
    }
    //change menues
    private void ToggleFreqMenu()
    {
        Toggle();
        Panel_Freq.Update();
        sceneLock.Toggle();
    }


    //***************************************
    //      Gain
    //***************************************
    public void UpdateGainButtonX(int myPassedXGainLocation)
    {
        //send to text_Overlay X  location
        Text_Overlay.UpdateGainButtonX(myPassedXGainLocation);
        string passedText1 = gainContentX.GetChild(myPassedXGainLocation).GetChild(0).gameObject.GetComponent<Text>().text;
        gainTextX.text = passedText1;
    }

    public void UpdateGainButtonY(int myPassedYGainLocation)
    {
        
        //send to text_Overlay X  location
        
        string passedText1 = gainContentY.GetChild(myPassedYGainLocation).GetChild(0).gameObject.GetComponent<Text>().text;
        gainTextY.text = passedText1;
    }

    public void GainXText(string myPassedXtext)
    {
        Text_Overlay.optionsGainButtonX(myPassedXtext);
        gainTextX.text = myPassedXtext;
    }

    public void GainYText(string myPassedYtext)
    {
        
        Text_Overlay.optionsGainButtonY(myPassedYtext);
        gainTextY.text = myPassedYtext;
    }

    public void GainButton()
    {
        ToggleGainMenu();
        sceneLock.Toggle();
    }

    public void GainButton2()
    {
        SmallPlaneToggle.Toggle();
        Panel_Gain.Update();
        Panel_Freq.Toggle();
        Keypad_RotCode.Toggle();
        //sceneLock.Toggle();
    }

    private void ToggleGainMenu()
    {
        Toggle();
        Panel_Gain.Update();
    }



    //***************************************
    //      Rotation
    //***************************************

    public void rotOutput(float rotOut)
    {

        rotationOutput = rotOut.ToString("F0");

        rotationText.GetComponent<Text>().text = "Rotation: " + rotationOutput + " Deg";
    
    }
    public void RotationButton()
    {
        ToggleRotation();
        sceneLock.Toggle();

    }
    public void RotationButton2()
    {
        SmallPlaneToggle.Toggle();
        Panel_Gain.Toggle();
        Panel_Freq.Toggle();
        Keypad_RotCode.Update();
        //sceneLock.Toggle();

    }
    private void ToggleRotation()
    {
        Toggle();
        Keypad_RotCode.Update();
    }


    //***************************************
    //      Store // Screenshot 
    //***************************************
    public void StoreButton()
    {
        Store_Button.StartCoroutine();
    }

    //***************************************
    //     Clear Button
    //***************************************
    public void PressedClearButton()
    {
        changeImage.ClearButtonimgCount();
    }

    public void PressedClearButton2()
    {

        changeImage.ClearButtonimgCount();
        change_2ndImage.ClearButtonimgCount2();
    }

    //***************************************
    //     Change Display Layout
    //***************************************

    public void colorChangeButton()
    {
        colorLayoutChange.colorChange();
    }

    public void PressedDisplayButton()
    {
        SceneManager.LoadScene("left_touchscreen");
    }
    public void PressedLeftDisplayButton()
    {
        SceneManager.LoadScene("pt2_Touch");
    }

    public void PressedReturnDisplayButton()
    {
        SceneManager.LoadScene("touchscreen demo");
    }
    
    public void Toggle()
    {
        ui.SetActive(false);
        
    }
}
