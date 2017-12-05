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
            ui.SetActive(true);
        }
        else if (this.ui.activeSelf == true)
        {
            Uniwest_Panel.Toggle();

        }

    }
}
