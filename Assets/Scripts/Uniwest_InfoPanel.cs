using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Uniwest_InfoPanel : MonoBehaviour {

    public GameObject ui;
    

    public void Uniwest_ImagePanel()
    {
        ui.SetActive(false);
    }

    public void Toggle()
    {
        ui.SetActive(!ui.activeSelf);
    }
}
