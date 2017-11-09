using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class GainUI : MonoBehaviour
{

    public Text GainText;

    void Update()
    {
        GainText.text = "Gain: " + OptionsStats.Gain.ToString() + "Deg";


    }
}
