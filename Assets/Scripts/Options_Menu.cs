using UnityEngine;
using UnityEngine.EventSystems;

public class Options_Menu : MonoBehaviour {

    [Header("Connecting Panels")]
    public Menu Menu;
    public Panel_Freq Panel_Freq;
    public Panel_Gain Panel_Gain;
    public Panel_HGain Panel_HGain;
    public Panel_VGain Panel_VGain;
    public Panel_Rotation Panel_Rotation;

    [Header("Options UI")]
    public GameObject ui;
    public GameObject menuOpenUI;
    
    
    public void Update()
    {
        //open inspector when menu button is pressed
       menuOpenUI.SetActive(true);
        
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
    //      V_Gain
    //***************************************
    public void V_GainButton()
    {
        ToggleVGain();
        Debug.Log("V_Gain button");
    }
    private void ToggleVGain()
    {
        Toggle();
        Panel_VGain.Update();
    }



    //***************************************
    //      Rotation
    //***************************************
    public void RotationButton()
    {
        ToggleRotation();
        Debug.Log("Return to Menu button");
    }
    private void ToggleRotation()
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
