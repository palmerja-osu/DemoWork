﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Change_2ndImage : MonoBehaviour
{

    public Sprite plane1; // I attched these from editor
    public Sprite plane2;
    public Sprite plane3;
    public Sprite plane4;
    public Sprite plane5;
    public int imgNumberCount;


    public void changeImages() // make sure to attach this to event trigger
    {
        switch (imgNumberCount)
        {

            case 0:
                imgNumberCount = 0;
                GetComponent<Image>().sprite = plane1;
                imgNumberCount++; //increase count so it gets higher and switches to different sprite
                break;
            case 1:
                GetComponent<Image>().sprite = plane2;
                imgNumberCount++;
                break;
            case 2:
                GetComponent<Image>().sprite = plane3;
                imgNumberCount++;
                break;
            case 3:
                GetComponent<Image>().sprite = plane4;
                imgNumberCount++;
                imgNumberCount = 0; //set back to first image
                break;

            default:
                Debug.Log("Error");
                break;
        }
    }

    public void ClearButtonimgCount2()
    {
        //when clear button is pressed set image to empty plane5
        GetComponent<Image>().sprite = plane5;
        imgNumberCount = 0;
    }
}
