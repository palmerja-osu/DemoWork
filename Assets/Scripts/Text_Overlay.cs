using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Overlay : MonoBehaviour {

    public ChangeImages ChangeImage;
    public Text channelOutput;

    public Transform freqContent;
    public Text myFreqOutput;

    public Transform freqUnitContent;
    public Text myFreqUnitOutput;

    public Transform gainContentX;
    public Text gainTextXOutput;

    public Transform gainContentY;
    public Text gainTextYOutput;

    public GameObject rotationText;
    public string rotationOutput;




    public void freqPlaneText(string freqText)
    {
        channelOutput.text = freqText;
    }

    public void UpdateFreq(int myPassedFreqLocation)
    {
        string passedText1 = freqContent.GetChild(myPassedFreqLocation).GetChild(0).gameObject.GetComponent<Text>().text;
        myFreqOutput.text = passedText1;
    }
    public void UpdateUnitFreq(int myPassedUnitLocation)
    {
        string passedText1 = freqUnitContent.GetChild(myPassedUnitLocation).GetChild(0).gameObject.GetComponent<Text>().text;
        myFreqUnitOutput.text = passedText1;
    }

    public void UpdateGainButtonX(int myPassedXGainLocation)
    {
        string passedText1 = gainContentX.GetChild(myPassedXGainLocation).GetChild(0).gameObject.GetComponent<Text>().text;
        gainTextXOutput.text = passedText1;
    }
    public void UpdateGainButtonY(int myPassedYGainLocation)
    {
        string passedText1 = gainContentY.GetChild(myPassedYGainLocation).GetChild(0).gameObject.GetComponent<Text>().text;
        gainTextYOutput.text = passedText1;
    }

    public void rotOutput(string rotOut)
    {

        rotationOutput = rotOut;
        //take string and output
        rotationText.GetComponent<Text>().text = rotationOutput + " Deg";

    }

}
