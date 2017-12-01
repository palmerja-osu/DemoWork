using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class Panel_Gain : MonoBehaviour
{
    [Header("Connecting Panels")]
    public GameObject ui;
    public GameObject Gain_MenuUI;
    public Options_Menu Options_Menu;
    public Small_PlaneToggle Small_PlaneToggle;

    [Header("text")]
    public Transform gainContentX;
    public Text gainXOutput;

    public Transform gainContentY;
    public Text gainYOutput;

    public double gainXNum = 0.0;
    public double gainYNum = 0.0;

    public void Update()
    {
        //open inspector when menu button is pressed
        Gain_MenuUI.SetActive(true);
        
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

    //***************************************
    //      XGain functionality
    //***************************************

    //set the public variable from what keypadNum sets
    public void UpdateXValue(double keypadNumX)
    {
        gainXNum = keypadNumX;
        string gainxString = gainXNum.ToString();
        gainXOutput.text = gainxString;
    }

    public void gainXButton()
    {
        Debug.Log("middleButton was pressed");
        //press button send to gain keypad


    }

    public void plus6_XButton()
    {
        //add 6 to xNum
        gainXNum = gainXNum + 6;
    }
    public void plus1_XButton()
    {
        //add 0.1 to xNum
        gainXNum = gainXNum + 0.1;
    }
    public void minus1_XButton()
    {
        //minus 0.1 from xNum
        gainXNum = gainXNum - 0.1;
    }
    public void minus6_XButton()
    {
        //minus 6 from xNum
        gainXNum = gainXNum - 6;
    }


    //***************************************
    //      YGain functionality
    //***************************************

    //set the public variable from what keypadNum sets
    public void UpdateYValue(double keypadNumY)
    {
        gainYNum = keypadNumY;
        string gainYString = gainYNum.ToString();
        gainYOutput.text = gainYString;
    }

    public void gainYButton()
    {
        Debug.Log("middleButton was pressed");
        //press button send to gain keypad


    }

    public void plus6_YButton()
    {
        //add 6 to xNum
        gainYNum = gainYNum + 6;
    }
    public void plus1_YButton()
    {
        //add 0.1 to xNum
        gainYNum = gainYNum + 0.1;
    }
    public void minus1_YButton()
    {
        //minus 0.1 from xNum
        gainYNum = gainYNum - 0.1;
    }
    public void minus6_YButton()
    {
        //minus 6 from xNum
        gainYNum = gainYNum - 6;
    }



    //***************************************
    //      UI toggle options
    //***************************************
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
