using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Timers;
using UnityEngine.SceneManagement;
using UnityEngine.UI.Extensions;

public class Keypad_YgainCode : MonoBehaviour {


    [Header("Connecting Functions")]
    public GameObject ui;
    public GameObject Panel_Gain_Obj;
    public string myUpdatedTextElement;
    public Text yText;

    [Header("Connecting Scripts")]
    public Options_Menu Options_Menu;
    public Panel_Gain Panel_Gain;
    public Keypad_XgainCode keypad_XgainCode;


    [Header("Keypad Num ref")]
    public GameObject number1;
    public GameObject number2;
    public GameObject number3;
    public GameObject number4;
    public GameObject number5;
    public GameObject number6;
    public GameObject number7;
    public GameObject number8;
    public GameObject number9;
    public GameObject numberClear;
    public GameObject number0;
    public GameObject numberSave;
    public GameObject numberDecimal;

    //text field for display of typing
    public GameObject text;
    //text for initial display
    //private string waitText = "30.0";
    //text for error message... formating
    private string errorText = "format: _ _ _ . _";
    //error bit.  Toggles between 1 and 0.  0 no error, 1 for error found
    private int errorFlag = 0;
    //lets you know when everything is saved / updated... 0 for not done, 1 for done.
    private int doneBit = 0;
    //used for error checking... to see if decimal button has been pressed.  Only allowing one more integer after.
    private int foundDecimal = 0;
    private int numPressed = 0;

    //List for holding keypad elements pressed with maximum number of key presses allowed
    List<string> cod = new List<string>(new string[5]);
    //Filters out any Null elements.  I.E. Maximum number of keys were not pressed.
    List<string> temp = new List<string>();
    //Filtered formatted list.  Example:  If no decimal pressed (0), converts to 0.0. OR Example: If no decimal pressed (100), converts to 100.0.
    //If a decimal was pressed than formatting should be good to go.
    List<string> formattedArray = new List<string>();

    int index = 0;
    double myElemInDoubleForm = 0.0;

    int colorChangeNumber = 0;

    public object Class1 { get; private set; }

    public void Update()
    {
        //open inspector when menu button is pressed
        ui.SetActive(true);
        Panel_Gain_Obj.SetActive(false);

    }
    public void Start()
    {
        //added
        delete();
        text.GetComponent<Text>().text = yText.text;
        doneBit = 1;
        
    }


    public void receiveSignal(GameObject go)
    {
        
        if (go == number1)
        {
            increaseCod("1");
        }
        if (go == number2)
        {
            increaseCod("2");
        }
        if (go == number3)
        {
            increaseCod("3");
        }
        if (go == number4)
        {
            increaseCod("4");
        }
        if (go == number5)
        {
            increaseCod("5");
        }
        if (go == number6)
        {
            increaseCod("6");
        }
        if (go == number7)
        {
            increaseCod("7");
        }
        if (go == number8)
        {
            increaseCod("8");
        }
        if (go == number9)
        {
            increaseCod("9");
        }
        if (go == number0)
        {
            increaseCod("0");
        }

        if (go == numberDecimal)
        {
            increaseCod(".");
        }

        if (go == numberClear)
        {
            //clear button
            delete();
        }

        if (go == numberSave)
        {
            string combinedString = string.Join("", cod.ToArray());
            
            //no change made or blank
            if (combinedString == "" || combinedString == myUpdatedTextElement){
                Toggle();
                //then re-initialize
                Panel_Gain.Update();
                index = 0;
                foundDecimal = 0;
                numPressed = 0;
                doneBit = 1;
                
                return;
            }
            
            //Fill temp array
            for (int i = 0; i < cod.Count; i++)
            {
                if (cod[i] != null)
                {
                    temp.Add(cod[i]);
                }
            }

            if (FormatChecker() == false)
            {
                //text.GetComponent<Text>().text = "bad num";
                //formatError(1);
                return;
            }
            
            //text.GetComponent<Text>().text = "good num";
            //okaybutton return to Option menu
            saveList();
        }
    }

    void delete()
    {
        for (int i = 0; i < cod.Count; i++)
        {
            cod[i] = null;
        }
        temp.Clear();
        formattedArray.Clear();
        index = 0;
        foundDecimal = 0;
        numPressed = 0;
        text.GetComponent<Text>().text = "";
        //text.GetComponent<Text>().text = temp.Count.ToString();

    }

    //public void increaseCod(int num, string info)
    public void increaseCod(string addText)
    {
        //if updateRotatePlane has sent information as codNew passes through 
        //isEmpty bool, therefore add something to makesure line is clear when
        //list is empty upon keypad input
        //if (index == 0)
        //{
        //    delete();
        //}
        if (index < 5)
        {
            if (addText == "." && foundDecimal == 1)
            {
                //formatError(1);
                return;
            }

            if (foundDecimal == 1)
            {
                cod[index] = addText;
                index++;
                foundDecimal = 2;
                text.GetComponent<Text>().text += addText;
                return;
            }

            if (foundDecimal == 2)
            {
                //formatError(1);
                return;
            }

            if (addText == ".")
            {


                if (errorFlag == 1 || doneBit == 1)
                {
                    delete();
                    text.GetComponent<Text>().text = "";
                    errorFlag = 0;
                    doneBit = 0;
                }
                
                //cod.Add(addText);
                cod[index] = addText;
                index++;
                foundDecimal = 1;
                text.GetComponent<Text>().text += addText;

            }

            else if (addText != "." && foundDecimal != 2)
            {
                //if the index is empty, make sure
                //Removes cod from adding to the end of errorText
                if (errorFlag == 1 || doneBit == 1)
                {
                    delete();
                    text.GetComponent<Text>().text = "";
                    errorFlag = 0;
                    doneBit = 0;                   
                }

                if (numPressed > 3)
                {
                    return;
                }

                else if(numPressed < 3)
                {
                    cod[index] = addText;
                    text.GetComponent<Text>().text += addText;
                    //text.GetComponent<Text>().text.Replace('_','_');
                    index++;
                    //text.GetComponent<Text>().text += index;
                    numPressed++;

                }
                
            }
        }

        return;
             
    }

    //List<string> formattedArray = new List<string>();

    private void formatArray(List<string> listForFormat)
    {
        int x = 0;
        int n = 2;
        for (int i = 0; i < listForFormat.Count; i++)
        {
            if (listForFormat[i] == ".")
            {
                //found decimal
                x = 1;
            }
            //add elements of listForFormat to formattedArray
            formattedArray.Add(listForFormat[i]);
        }
       
        if (x == 1 && formattedArray.Count > 3)
        {
            //found decimal, lets check for any leading 0's
            for (int j = 0; j < formattedArray.Count; j++)
            {
                if(formattedArray[j] == "0")
                {
                    //truncate leading 0's
                    formattedArray[j] = "";

                }

                else if(formattedArray[j] != "0")
                {
                    //found a non-zero leading number, break loop.
                    j = formattedArray.Count + 1;
                }

            }
        }
//        string dugh = string.Join("", formattedArray.ToArray());
//        Debug.Log("gksdjf sdlkfj   " + dugh);

        if (x != 1)
        //No decimal input by user... so lets add one, plus subsequent 0 placeholder.
        {
            // no decimal found
            if (listForFormat.Count > 3)
            {
                formattedArray[0] = "";
                formattedArray[1] = "";
                formattedArray.Add(".");
                formattedArray.Add("0");
            }

            else
            {
                formattedArray.Add(".");
                formattedArray.Add("0");
            }
        }

        if (formattedArray[0] == "." || formattedArray[0] == "")
        {
            for (n = 2; n > 0; n--)
            {
                if (n == 2)
                {
                    formattedArray.Add(formattedArray[1]);
                }
                    
                if (n == 1)
                {
                    formattedArray[1] = formattedArray [0];
                }
                
            }

            formattedArray[0] = "0";   
        }
        
    }

   

    void formatError(int tempSize)
    {
        //clear
        delete();
        errorFlag = 1;
        text.GetComponent<Text>().text = errorText; // then show error output message
    }

    private bool FormatChecker()
    {
        //string element = string.Join("", temp.ToArray());

        if (temp.Count == 5)
        //******xxx.xx
        {
            if (temp[0] == "0")
            {
                //Automatic Pass 0xx.x, all possible values are valid
                return true;
            }

            if (temp[0] == "1")
            {
                //*******first digit must be a 1
                //*******1xx.x i.e. 100.0 or less
                if (temp[1] != "1" && temp[1] != "0")
                //*******1_x.x first digit is a 1, second digit better be either a 0 or 1, i.e. 11x.x or 10x.x.  If not then error out.
                {
                    formatError(temp.Count);
                    return false;
                }
                if(temp[1] == "1")
                {
                    //The second integer is a 1 or 0, otherwise it would have failed above. Not looking at case 0, all integer values for that would pass. ex. 109.9
                    //11x.x
                    if (temp[2] != "0" && temp[2] != "1" && temp[2] != "2" && temp[2] != "3" && temp[2] != "4")
                    {
                        formatError(temp.Count);
                        return false;
                    }
                }
                else
                {
                    return true;
                }
                
            }

            else
            {
                //invalid first integer
                formatError(temp.Count);
                return false;
            }
        }

        if (temp.Count == 4)
        //******xx.x
        {

            if (temp[2] == ".")
            //xx.x, all valid integers for x
            {
                return true;
            }
            if (temp[2] != "." && temp[1] != ".")
            //xxxx
            {
                if(temp[0] != "0" && temp[1] != "1")
                {
                    formatError(temp.Count);
                    return false;
                }
                if(temp[2] != "1" && temp[2] != "0")
                {
                    formatError(temp.Count);
                    return false;
                }
                if(temp[3] != "0" && temp[3] != "1" && temp[3] != "2" && temp[3] != "3" && temp[3] != "4")
                {
                    formatError(temp.Count);
                    return false;
                }
            }
            
        }

        if (temp.Count == 3)
        // xxx or x.x
        {
            if (temp[1] != ".")
            //must be whole integer value, xxx
            {
                if (temp[0] != "0" && temp[0] != "1")
                //_xx, only valid first integers are 0 or 1, otherwise error
                {
                    formatError(temp.Count);
                    return false;
                }

                if (temp[1] == "1")
                //01x, 11x 
                {
                    if (temp[2] != "0" && temp[2] != "1" && temp[2] != "2" && temp[2] != "3" && temp[2] != "4")
                    //(11x, only valid integers are 0,1,2,3,4, error otherwise
                    {
                        formatError(temp.Count);
                        return false;
                    }
                }
                if (temp[2] == ".")
                //xx.  cannot end with a decimal.
                {
                    formatError(temp.Count);

                    return false;
                }
            }

            else if(temp[1] == ".")
            //x.x, all valid integers for x
            {
                return true;
            }

        }

        if (temp.Count == 2)
        // xx
        {
            if (temp[1] == ".")
            //x., cannot end with a decimal
            {
                formatError(temp.Count);
                //text.GetComponent<Text>().text = "bad num 2.0";
                return false;
            }
            else
            //xx, all integers are valid for x
            {
                return true;
            }
        }

        else
        {
            return true;
        }
        
    }

    public void plus6dB_y(double x)
    {
        myElemInDoubleForm = x;
        
        yText.GetComponent<Text>().text = myElemInDoubleForm.ToString("0.0");
        //update gain button in main menue
        Options_Menu.GainYText(myElemInDoubleForm.ToString("0.0"));
       
       

    }

    void saveList()
    {
        //save List option here
        //check set  parameters
        //then send List to Options_Menu

        //myElementInScrollText = string.Join("", temp.ToArray());
        //double myScrollElemInDoubleForm = Convert.ToDouble(myElementInScrollText);
        formatArray(temp);
        myUpdatedTextElement = string.Join("", formattedArray.ToArray());
        sortList();
        doneBit = 1;
        index = 0;
        foundDecimal = 0;
        numPressed = 0;

        //update keypad typing space
        text.GetComponent<Text>().text = myUpdatedTextElement;

        //my Element in Double form if i need it
        myElemInDoubleForm = Convert.ToDouble(myUpdatedTextElement);
        //update gain button in main menue

        yText.text = myUpdatedTextElement;
        //update gainXNum in Panel_Gain.cs

        if (colorChangeNumber == 1)  //if xy button is pressed
        {
            //if button is red update x and y
            Panel_Gain.UpdateXValue(myElemInDoubleForm);
            Panel_Gain.UpdateYValue(myElemInDoubleForm);
            //update x and y on menu
            Options_Menu.GainYText(myUpdatedTextElement);
            Options_Menu.GainXText(myUpdatedTextElement);
        }
        else if(colorChangeNumber == 0){
            //if button is not red only update Y
            Panel_Gain.UpdateYValue(myElemInDoubleForm);
            Options_Menu.GainYText(myUpdatedTextElement);
        }
        
        //clear arrays;
        temp.Clear();
        formattedArray.Clear();
       
    }

    void sortList()
    {
        //toggle keypad off and open panel gain again
        Toggle();
        Panel_Gain.Update();
    }

    
    public void Toggle()
    {
        //incase its enabled, flipped and set inactive and visa versa
        ui.SetActive(!ui.activeSelf);
        
    }

    public void updateBothButtons(int switchColor)
    {
        //check and update color number
        colorChangeNumber = switchColor;
    }
}



