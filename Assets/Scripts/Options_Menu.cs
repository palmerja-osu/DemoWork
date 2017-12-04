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
    public Change_2ndImage change_2ndImage;
    public Panel_Freq Panel_Freq;
    public Panel_Gain Panel_Gain;
    public Keypad_RotCode Keypad_RotCode;
    public Small_PlaneToggle SmallPlaneToggle;
    public Store_Button Store_Button;

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
        Debug.Log("pressed display button");
    }

    public void PressedChannelButton2()
    {

        changeImage.changeImages();
        change_2ndImage.changeImages();
        Debug.Log("pressed display button");
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
        //frequencyText.text = "Frequency: " + OptionsStats.Frequency.ToString() + "MHz";  //could do this
        ToggleFreqMenu();
        Debug.Log("Frequency button");
    }
    //functionality for second scene
    public void FrequencyButton2()
    {
        SmallPlaneToggle.Toggle();
        Panel_Freq.Toggle();
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
    public void UpdateGainButtonX(int myPassedXGainLocation)
    {
        string passedText1 = gainContentX.GetChild(myPassedXGainLocation).GetChild(0).gameObject.GetComponent<Text>().text;
        gainTextX.text = passedText1;
    }

    public void UpdateGainButtonY(int myPassedYGainLocation)
    {
        string passedText1 = gainContentY.GetChild(myPassedYGainLocation).GetChild(0).gameObject.GetComponent<Text>().text;
        gainTextY.text = passedText1;
    }

    public void GainXText(string myPassedXtext)
    {
        gainTextX.text = myPassedXtext;
    }

    public void GainYText(string myPassedYtext)
    {
        gainTextY.text = myPassedYtext;
    }

    public void GainButton()
    {
        ToggleGainMenu();
        Debug.Log("Gain button");
    }

    public void GainButton2()
    {
        SmallPlaneToggle.Toggle();
        Panel_Gain.Toggle();
        Debug.Log("Gain2 button");
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
        Store_Button.StartCoroutine();
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

    }
    public void RotationButton2()
    {
        SmallPlaneToggle.Toggle();
        Keypad_RotCode.Toggle(); 
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
    }

    public void PressedClearButton2()
    {

        changeImage.ClearButtonimgCount();
        change_2ndImage.ClearButtonimgCount2();
        Debug.Log("pressed clear button");
    }

    //***************************************
    //     Change Display Layout
    //***************************************

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

        //incase its enabled, flipped and set inactive and visa versa
        ui.SetActive(!ui.activeSelf);


    }
}
