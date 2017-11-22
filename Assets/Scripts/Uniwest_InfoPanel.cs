using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Uniwest_InfoPanel : MonoBehaviour {

    public GameObject ui;

    // Update is called once per frame
    public void Update () {
        
         ui.SetActive(true);
        
    }

    public void Uniwest_ImagePanel()
    {
        Toggle();
    }

    public void Toggle()
    {
        ui.SetActive(!ui.activeSelf);
    }
}
