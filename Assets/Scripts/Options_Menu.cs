using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Options_Menu : MonoBehaviour {

    [Header("Connecting Panels")]

    public Menu Menu;
    public Panel_Freq Panel_Freq;
    public Panel_Gain Panel_Gain;
    public Panel_HGain Panel_HGain;
    public Keypad_Code Keypad_Code;

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
    //      Frequency
    //***************************************
    public void FrequencyButton()
    {
        
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


    //***************************************
    //      V_Gain
    //***************************************
    public void H_GainButton()
    {
        ToggleHGain();
        Debug.Log("Gain button");
    }

    private void ToggleHGain()
    {
        Toggle();
        Panel_HGain.Update();
    }



   

    //***************************************
    //      Rotation
    //***************************************
    
    public void rotOutput(string[] rotOut)
    {
        //set output to string from dialpad
       // rotationOutput = rotOut;
        
        rotationText.GetComponent<Text>().text = "Rotation: " + rotationOutput + "Deg";
    
    }
    public void RotationButton()
    {
        ToggleRotation();
        
        Debug.Log("Return to Menu button");
    }
    private void ToggleRotation()
    {
        Toggle();
        Keypad_Code.Update();
    }

    //***************************************
    //     Return to Menu
    //***************************************
    public void MenuButton()
    {
        ToggleMenu();
        Debug.Log("V_Gain button");
    }
    private void ToggleMenu()
    {
        Toggle();
        Menu.Toggle();
    }




    public void Toggle()
    {

        //incase its enabled, flipped and set inactive and visa versa
        ui.SetActive(!ui.activeSelf);


    }
}
