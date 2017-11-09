using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class FrequencyUI : MonoBehaviour {


    public Text frequencyText;
	
	void Update () {
        frequencyText.text = "Frequency: " + OptionsStats.Frequency.ToString() + "MHz";


	}
}
