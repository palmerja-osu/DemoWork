using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class HGainUI : MonoBehaviour
{


    public Text HGainText;
    

    void Update()
    {
        //HGain output
        HGainText.text = "HGain: " + OptionsStats.HGain.ToString() + "dB";

       

    }
}
