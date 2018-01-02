using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Uniwest_InfoPanel : MonoBehaviour {

    public GameObject ui;
    

    public void Uniwest_ImagePanel()
    {
        Debug.Log("pressed the butotn");
        ui.SetActive(false);
    }

    public void Toggle()
    {
        Debug.Log("toggle pressed");
        ui.SetActive(!ui.activeSelf);
    }
}
