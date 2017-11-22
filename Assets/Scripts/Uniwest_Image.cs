using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uniwest_Image : MonoBehaviour {


    public Uniwest_InfoPanel Uniwest_Panel;
    public GameObject ui;

    public void UniwestPanel()
    {
        if (this.ui.activeSelf == false)
        {
            Debug.Log("if activeSelf == false");
            ui.SetActive(true);
        }
        else if (this.ui.activeSelf == true)
        {
            Debug.Log("else Toggle();");
            Uniwest_Panel.Toggle();

        }

    }
}
