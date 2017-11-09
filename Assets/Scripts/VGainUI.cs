using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class VGainUI : MonoBehaviour {


    public Text VGainText; 
    

	void Start () {

        VGainText.text = "VGain: " + OptionsStats.VGain.ToString() + "Deg";

    }
	
	
}
