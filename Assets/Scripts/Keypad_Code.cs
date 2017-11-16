using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

public class Keypad_Code : MonoBehaviour {

    public int[] acceptCode;

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

    public string waitText;
    public string errorText;
    public string acceptText;

    List<int> cod = new List<int>();
    int index = 0;

    void Start()
    {
        text.GetComponent<Text>().text = waitText;
    }

    public void receiveSignal(GameObject go)
    {
        if (go == number1)
        {
            Debug.Log("pressed 1");
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
            attemptAuthentication();
        }


    }


    void attemptAuthentication()
    {
        if (index == acceptText.Length)
        {
            bool certo = true;
            for(int i = 0; i < acceptText.Length; i++)
            {
                if (cod[i] != acceptText[i])
                {
                    certo = false;
                    break;
                }
            }
            if (certo)
            {
                text.GetComponent<Text>().text = acceptText;
            }
            else
            {
                text.GetComponent<Text>().text = errorText;
            }
        }
        else
        {
            //if the password text errors, delete text
            text.GetComponent<Text>().text = errorText;
            deleteNoChangeText();  
        }
    }

    void deleteNoChangeText()
    {
        cod.Clear();
        index = 0;
    }


    void delete()
    {

        index--;
        text.GetComponent<Text>().text = waitText;
    }

    public void increaseCod(int num)
    {
        cod.Add(num);
        index++;

        text.GetComponent<Text>().text = "";

        for (int i=0; i< index; i++)
        {
            text.GetComponent<Text>().text += "*";
        }




    }


}
