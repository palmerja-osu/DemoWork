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
    public Keypad_XgainCode keypad_XgainCode;
    public Keypad_YgainCode keypad_YgainCode;
    public sceneLock sceneLock;

    [Header("text")]
    public Transform gainContentX;
    public Text gainXOutput;

    public Transform gainContentY;
    public Text gainYOutput;

    public double gainXNum = 30.0;
    public double gainYNum = 30.0;

    [Header("UI Images")]
    public Button theButton;
    public Image theImage;
    private int colorSwitchTrue = 0;
    public Sprite lockImage1;
    public Sprite lockImage2;

    public void Update()
    {
        //open inspector when menu button is pressed
        Gain_MenuUI.SetActive(true);
        
    }
    

    public void exitButton()
    {
        Toggle();
        returnToOptions();
    }
    
    //exit button for second scene
    public void exitButton2()
    {
        Toggle();
        returnToOptions();
        Small_PlaneSwitch();
    }

    //***************************************
    //      XGain functionality
    //***************************************

    //set the public variable from what keypadNum sets
    public void UpdateXValue(double keypadNumX)
    {
        gainXNum = keypadNumX;
        string gainxString = gainXNum.ToString("0.0");
        Options_Menu.GainXText(gainxString); //send to menu
        gainXOutput.text = gainxString;
    }

    public void gainXButton()
    {
        
        //press button send to gain keypad
        keypad_XgainCode.Update();
        keypad_XgainCode.Start();
    }

    public void plus6_XButton()
    {
        //add 6 to xNum
        gainXNum = gainXNum + 6;
        if (gainXNum > 114.0)
        {
            gainXNum = 114.0;
            UpdateXValue(gainXNum);
            keypad_XgainCode.plus6dB_x(gainXNum);
            if(colorSwitchTrue == 1)
            {
                keypad_YgainCode.plus6dB_y(gainXNum);
                UpdateYValue(gainXNum);
            }
        }
        else
        {
            UpdateXValue(gainXNum);
            keypad_XgainCode.plus6dB_x(gainXNum);
            if (colorSwitchTrue == 1)
            {
                keypad_YgainCode.plus6dB_y(gainXNum);
                UpdateYValue(gainXNum);
            }
        }
    }
    public void plus1_XButton()
    {
        //add 0.1 to xNum
        gainXNum = gainXNum + 0.1;
        if (gainXNum > 114.0)
        {
            gainXNum = 114.0;
            UpdateXValue(gainXNum);
            keypad_XgainCode.plus6dB_x(gainXNum);
            if (colorSwitchTrue == 1)
            {
                keypad_YgainCode.plus6dB_y(gainXNum);
                UpdateYValue(gainXNum);
            }
        }
        else
        {
            UpdateXValue(gainXNum);
            keypad_XgainCode.plus6dB_x(gainXNum);
            if (colorSwitchTrue == 1)
            {
                keypad_YgainCode.plus6dB_y(gainXNum);
                UpdateYValue(gainXNum);
            }
        }
    }
    public void minus1_XButton()
    {
        //minus 0.1 from xNum
        gainXNum = gainXNum - 0.1;
        if (gainXNum < 0.0)
        {
            gainXNum = 0.0;
            UpdateXValue(gainXNum);
            keypad_XgainCode.plus6dB_x(gainXNum);
            if (colorSwitchTrue == 1)
            {
                keypad_YgainCode.plus6dB_y(gainXNum);
                UpdateYValue(gainXNum);
            }
        }
        else
        {
            UpdateXValue(gainXNum);
            keypad_XgainCode.plus6dB_x(gainXNum);
            if (colorSwitchTrue == 1)
            {
                keypad_YgainCode.plus6dB_y(gainXNum);
                UpdateYValue(gainXNum);
            }
        }
    }
    public void minus6_XButton()
    {
        //minus 6 from xNum
        gainXNum = gainXNum - 6;
        if (gainXNum < 0.0)
        {
            gainXNum = 0.0;
            UpdateXValue(gainXNum);
            keypad_XgainCode.plus6dB_x(gainXNum);
            if (colorSwitchTrue == 1)
            {
                keypad_YgainCode.plus6dB_y(gainXNum);
                UpdateYValue(gainXNum);
            }
        }
        else
        {
            UpdateXValue(gainXNum);
            keypad_XgainCode.plus6dB_x(gainXNum);
            if (colorSwitchTrue == 1)
            {
                keypad_YgainCode.plus6dB_y(gainXNum);
                UpdateYValue(gainXNum);
            }
        }
           
    }


    //***************************************
    //      YGain functionality
    //***************************************

    //set the public variable from what keypadNum sets
    //set the public variable from what keypadNum sets
    public void UpdateYValue(double keypadNumY)
    {
        gainYNum = keypadNumY;
        string gainYString = gainYNum.ToString("0.0"); //set as string
        Options_Menu.GainYText(gainYString); //send to menu
        gainYOutput.text = gainYString;

    }

    public void gainYButton()
    {
        
        //press button send to gain keypad
        keypad_YgainCode.Update();
        keypad_YgainCode.Start();
    }

    public void plus6_YButton()
    {
        //add 6 to xNum
        gainYNum = gainYNum + 6;
        if (gainYNum > 114.0)
        {
            gainYNum = 114.0;
            UpdateYValue(gainYNum);
            keypad_YgainCode.plus6dB_y(gainYNum);
            if (colorSwitchTrue == 1)
            {
                keypad_XgainCode.plus6dB_x(gainYNum);
                UpdateXValue(gainYNum);
            }
        }
        else
        {
            UpdateYValue(gainYNum);
            keypad_YgainCode.plus6dB_y(gainYNum);
            if (colorSwitchTrue == 1)
            {
                keypad_XgainCode.plus6dB_x(gainYNum);
                UpdateXValue(gainYNum);
            }
        }
    }
    public void plus1_YButton()
    {
        //add 0.1 to xNum
        gainYNum = gainYNum + 0.1;
        if (gainYNum > 114.0)
        {
            gainYNum = 114.0;
            UpdateYValue(gainYNum);
            keypad_YgainCode.plus6dB_y(gainYNum);
            if (colorSwitchTrue == 1)
            {
                keypad_XgainCode.plus6dB_x(gainYNum);
                UpdateXValue(gainYNum);
            }
        }
        else
        {
            UpdateYValue(gainYNum);
            keypad_YgainCode.plus6dB_y(gainYNum);
            if (colorSwitchTrue == 1)
            {
                keypad_XgainCode.plus6dB_x(gainYNum);
                UpdateXValue(gainYNum);
            }
        }
    }
    public void minus1_YButton()
    {
        //minus 0.1 from xNum
        gainYNum = gainYNum - 0.1;
        if (gainYNum < 0.0)
        {
            gainYNum = 0.0;
            UpdateYValue(gainYNum);
            keypad_YgainCode.plus6dB_y(gainYNum);
            if (colorSwitchTrue == 1)
            {
                keypad_XgainCode.plus6dB_x(gainYNum);
                UpdateXValue(gainYNum);
            }
        }
        else
        {
            UpdateYValue(gainYNum);
            keypad_YgainCode.plus6dB_y(gainYNum);
            if (colorSwitchTrue == 1)
            {
                keypad_XgainCode.plus6dB_x(gainYNum);
                UpdateXValue(gainYNum);
            }
        }
    }
    public void minus6_YButton()
    {
        //minus 6 from xNum
        gainYNum = gainYNum - 6;
        if (gainYNum < 0.0)
        {
            gainYNum = 0.0;
            UpdateYValue(gainYNum);
            keypad_YgainCode.plus6dB_y(gainYNum);
            if (colorSwitchTrue == 1)
            {
                keypad_XgainCode.plus6dB_x(gainYNum);
                UpdateXValue(gainYNum);
            }
        }
        else
        {
            UpdateYValue(gainYNum);
            keypad_YgainCode.plus6dB_y(gainYNum);
            if (colorSwitchTrue == 1)
            {
                keypad_XgainCode.plus6dB_x(gainYNum);
                UpdateXValue(gainYNum);
            }
        }

    }


    //***************************************
    //      UI toggle options
    //***************************************

    public void ChangeButtonColour()
    {
        if (colorSwitchTrue == 0)
        {
            colorSwitchTrue = 1;
            colorSwitch(colorSwitchTrue);
        }
        else 
        {
            colorSwitchTrue = 0;
            colorSwitch(colorSwitchTrue);
        }
    }

    public void colorSwitch(int colorSwitch)
    {
        if (colorSwitch == 1)
        {
            //color number is 1 
            //activate both sides
            theButton.GetComponent<Image>().color = Color.red;
            theImage.GetComponent<Image>().sprite = lockImage2;

            //update both keypads
            keypad_YgainCode.updateBothButtons(colorSwitch);
            keypad_XgainCode.updateBothButtons(colorSwitch);
        }
        if(colorSwitch == 0)
        {
            //color is 0
            //sides are independent
            theButton.GetComponent<Image>().color = Color.gray;
            theImage.GetComponent<Image>().sprite = lockImage1;
            //update both keypads
            keypad_YgainCode.updateBothButtons(colorSwitch);
            keypad_XgainCode.updateBothButtons(colorSwitch);
        }
            

        
    }
    private void returnToOptions()
    {
        sceneLock.Update();
        Options_Menu.Update();
    }

    private void Small_PlaneSwitch()
    {
        Small_PlaneToggle.Update();
    }

    public void Toggle()
    {

        //incase its enabled, flipped and set inactive and visa versa
        ui.SetActive(false);

    }
}
