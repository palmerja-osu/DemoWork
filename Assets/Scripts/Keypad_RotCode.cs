using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine.SceneManagement;

public class Keypad_RotCode : MonoBehaviour {


    [Header("Connecting Functions")]
    public Options_Menu Options_Menu;
    public Text_Overlay Text_Overlay;
    public GameObject ui;
    public Small_PlaneToggle Small_PlaneToggle;
    public rotatePlane rotatePlane;


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

    public GameObject text;

    private string waitText = "";
    private string errorText = "Error: >=360";

    List<float> cod = new List<float>();
    int index = 0;

    public object Class1 { get; private set; }

    public void Update()
    {
        //open inspector when menu button is pressed
        ui.SetActive(true);

    }
    void Start()
    {
        waitText = "";
        text.GetComponent<Text>().text = waitText;
    }

    public void receiveSignal(GameObject go)
    {
        
        if (go == number1)
        {
            increaseCod(1);
        }
        if (go == number2)
        {
            increaseCod(2);
        }
        if (go == number3)
        {
            increaseCod(3);
        }
        if (go == number4)
        {
            increaseCod(4);
        }
        if (go == number5)
        {
            increaseCod(5);
        }
        if (go == number6)
        {
            increaseCod(6);
        }
        if (go == number7)
        {
            increaseCod(7);
        }
        if (go == number8)
        {
            increaseCod(8);
        }
        if (go == number9)
        {
            increaseCod(9);
        }
        if (go == number0)
        {
            increaseCod(0);
        }

        if (go == numberClear)
        {
            //clear button
            delete();
        }

        if (go == numberSave)
        {
            //okaybutton return to Option menu
            saveList();
        }


    }



    void delete()
    {
        cod.Clear();
        index = 0;
        text.GetComponent<Text>().text = waitText;
    }

    //update z plane when moving info from I-plane
    //need to work on!!!!!!!!
    public void updateRotatePlane(string rotValues)
    {
        var codNew = rotValues.Split(',').Select(Int32.Parse).ToList();
        List<float> cod = codNew.Select<int, float>(i =>i).ToList();
        Debug.Log(cod[0]);
    }

    public void increaseCod(int num)
    {
 
 
        if (index < 3)
        {
            //if the index is empty, make sure
            //Removes cod from adding to the end of errorText
            bool isEmpty = !cod.Any();
            if (isEmpty)
            {
                delete();
            }

            cod.Add(num);
            index++;
            text.GetComponent<Text>().text += num;

        }
        else
        {
            Debug.Log("list is full");
            //if first position is greater than 3
            if (cod[0] > 3)
            {
                if (index > 3)
                {
                    Debug.Log("cod[0] > first greater than 3 oops");
                    //clear
                    delete();
                    text.GetComponent<Text>().text = errorText; // then show error output message
                }


            }
            //if cod 300 >= cod <= 399
            if (cod[0] == 3)
            {
                //if cod in 300 range is >= 60
                if (cod[0] == 3 && cod[1] > 5)
                {
                    Debug.Log("cod[1] > less than 400 but greater than 35-");
                    //clear
                    delete();
                    text.GetComponent<Text>().text = errorText; // then show error output message

                }

                //if second position 5 or less
                else if (cod[0] == 3 && cod[1] <= 5)
                {
                    //then check if third position is no higher than 0 IF first position > 3 and second > 5
                    //redudent test case
                    if (cod[2] >= 9)
                    {
                        Debug.Log("greater than 360 less than 399");
                        delete();
                        text.GetComponent<Text>().text = errorText; // then show error output message

                    } 
                }
                else
                {
                    Debug.Log("just let it happen");
                    //let this happen?
                }
            }
            else
            {
                //send to rotOutput in Options_Menu
                Debug.Log("List is OKAY");


            }

        }
        
           
    }

    void saveList()
    {
        //save List option here
        //check set  parameters
        //then send List to Options_Menu

        Debug.Log("saveList call");
        //if first position is greater than 3
        if (cod[0] >= 3)
        {
            if (cod[0] >= 3 && index > 3)
            {
                //clear
                delete();
                text.GetComponent<Text>().text = errorText; // then show error output message

            }
            if (cod[0] > 3 && index == 3)
            {
               
                    delete();
                    text.GetComponent<Text>().text = errorText; // then show error output message
              
            }
            else if (cod[0] == 3 && index == 3)
            {
                if (cod[0] == 3 && cod[1] > 5)
                {
                    Debug.Log("in second else if statement");
                    //clear
                    delete();
                    text.GetComponent<Text>().text = errorText; // then show error output message
                   
                }
                else if (cod[0] == 3 && index == 1)
                {
                    //let this happen?
                    sortList();

                }
                else
                {

                    //let this happen?
                    sortList();

                }
            }
            else
            {
                //let this happen?
                sortList();
            }
        }
        else
        {
            Debug.Log("save and send to sortList");
            //if less than 3, send to sortList
            sortList();

        }


    }

    void sortList()
    {
     

        //rewrite List to a string
        //this overload calls ToString() on each input element): string.Join(",", ints)
        var stringsArray = cod.Select(i => i.ToString()).ToArray();
        var values = string.Join("", stringsArray);

        //check scene
        //if scene two, send to second option
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("pt2_Touch"))
        {
            returnOption2();
        }
        else
        {
            //toggle window off
            returnOption();
        }

        rotatePlane.updateRot(values);
        //Options_Menu.rotOutput(values);
        //Text_Overlay.rotOutput(values);

    }
    void returnOption()
    {
        //toggle UI off and Options on
        Toggle();
        Options_Menu.Update();
    }
    void returnOption2()
    {
        //toggle UI off and Options on
        Toggle();
        Small_PlaneToggle.Toggle();
        //Options_Menu.Update();
    }



    public void Toggle()
    {

        //incase its enabled, flipped and set inactive and visa versa
        ui.SetActive(!ui.activeSelf);

    }
}



