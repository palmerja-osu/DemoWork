﻿using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;

public class Keypad_RotCode : MonoBehaviour {


    [Header("Connecting Functions")]
    public Options_Menu Options_Menu;
    public Text_Overlay Text_Overlay;
    public GameObject ui;
    public Small_PlaneToggle Small_PlaneToggle;
    public rotatePlane rotatePlane;
    public sceneLock sceneLock;


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

    List<int> cod = new List<int>();
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
    public void updateRotatePlane(float rotValues)
    {
        
        //inverse the output
        rotValues = rotValues - 360;
        if (rotValues < 0)
            rotValues = rotValues * -1;
        
        delete();

        string rotationOutput = rotValues.ToString("F0");

        var codNew = rotationOutput.Split(',').Select(Int32.Parse).ToList();
        cod.Add(codNew[0]);
        text.GetComponent<Text>().text += codNew[0];
        

        
    }

    public void increaseCod(int num)
    {
        
        //if updateRotatePlane has sent information as codNew passes through 
        //isEmpty bool, therefore add something to makesure line is clear when
        //list is empty upon keypad input
        if(index == 0)
        {
            delete();
        }
 
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
            //if first position is greater than 3
            if (cod[0] > 3)
            {
                if (index > 3)
                {
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
                        delete();
                        text.GetComponent<Text>().text = errorText; // then show error output message

                    } 
                }
                else
                {
                    //let this happen?
                }
            }
            else
            {
                //send to rotOutput in Options_Menu
               //list is okay

            }

        }
        
           
    }

    void saveList()
    {
        //save List option here
        //check set  parameters
        //then send List to Options_Menu
        
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
            //if less than 3, send to sortList
            sortList();

        }


    }

    void sortList()
    {
        
        //rewrite List to a string
        //var stringsArray = cod.Select(i => i.ToString()).ToArray();
        //var values = string.Join("", stringsArray);

        //rewrite list to int
        float values = 0;
        foreach(float entry in cod)
        {
            values = 10 * values + entry;
        }
        //flip array
        
       
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
    }

    //toggle UI off and Options on
    void returnOption()
    {
        Toggle();
        Options_Menu.Update();
        sceneLock.Update();
    }
    void returnOption2()
    {
        Toggle();
        Small_PlaneToggle.Update();
        sceneLock.Update();
    }



    public void Toggle()
    {
        ui.SetActive(false);

    }
}



