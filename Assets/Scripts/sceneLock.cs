  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sceneLock : MonoBehaviour {

    //button is pressed
    //lock the scene
    [Header("Connecting Panels")]
    public Button Channel;
    public Button Frequency;
    public Button Gain;
    public Button Rotation;
    public Button Clear;
    public Button NULL;
    public Button Screenshot;
    public Button Display;
    public Button colorChanger;
    public Collider rotateImage;

    [Header("UI Images")]
    public Sprite plane1; // I attched these from editor
    public Sprite plane2;
    public Button theButton;
    public int imgNumberCount;
    public GameObject ui;


    public void Update()
    {
        //open inspector when menu button is pressed
        ui.SetActive(true);

    }
    public void lockImage() // make sure to attach this to event trigger
    {
        switch (imgNumberCount)
        {

            case 0:
                theButton.GetComponent<Image>().color = Color.red;
                GetComponent<Image>().sprite = plane2;
                Channel.interactable = false;
                colorChanger.interactable = false;
                Frequency.interactable = false;
                Gain.interactable = false;
                Rotation.interactable = false;
                Clear.interactable = false;
                NULL.interactable = false;
                Screenshot.interactable = false;
                Display.interactable = false;
                rotateImage.enabled = false;


                imgNumberCount++; //increase count so it gets higher and switches to different sprite
                break;
            case 1:
                GetComponent<Image>().sprite = plane1;
                theButton.GetComponent<Image>().color = Color.white;
                Channel.interactable = true;
                colorChanger.interactable = true;
                Frequency.interactable = true;
                Gain.interactable = true;
                Rotation.interactable = true;
                Clear.interactable = true;
                NULL.interactable = true;
                Screenshot.interactable = true;
                Display.interactable = true;
                rotateImage.enabled = true;
                imgNumberCount++;
                imgNumberCount = 0;
                break;
           
            default:
                Debug.Log("Error");
                break;
        }
    }

    //turn off image
    public void Toggle()
    {
        ui.SetActive(false);

    }
}
