using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class colorLayoutChange : MonoBehaviour {

    [Header("Connecting Panels")]
    public Options_Menu Options_Menu;

    [Header("Button images")]
    public Sprite plane1; // I attched these from editor
    public Sprite plane2;
    public Sprite plane3;
    public Sprite plane4;
    public Sprite plane5;
    public Sprite plane6;
    public Sprite plane7;
    public Sprite plane8;
    public Sprite plane9;
    public Sprite plane10;

    [Header("connecting buttons")]
    public Image Channel;
    public Image Frequency;
    public Image Gain;
    public Image Rotation;
    public Image Clear;
    public Image NULL;
    public Image Store_Button;
    public Image Display;

    [Header("connecting text")]
    public Text ChannelText;
    public Text FrequencyText1;
    public Text FrequencyText2;
    public Text FrequencyText3;
    public Text GainText1;
    public Text GainText2;
    public Text GainText3;
    public Text GainText4;
    public Text GainText5;
    public Text GainText6;
    public Text GainText7;
    public Text RotationText;
    public Text ClearText;
    public Text NULLText;
    public Text Store_ButtonText;
    public Text DisplayText;
    
    public int imgNumberCount;
    

    public void colorChange()
    {
        switch (imgNumberCount)
        {

            case 0:
                imgNumberCount = 0;
                Channel.GetComponent<Image>().sprite = plane2;
                Frequency.GetComponent<Image>().sprite = plane2;
                Gain.GetComponent<Image>().sprite = plane2;
                Rotation.GetComponent<Image>().sprite = plane2;
                Clear.GetComponent<Image>().sprite = plane2;
                NULL.GetComponent<Image>().sprite = plane2;
                Store_Button.GetComponent<Image>().sprite = plane2;
                Display.GetComponent<Image>().sprite = plane2;
                imgNumberCount++;
                break;

            case 1:
                Channel.GetComponent<Image>().sprite = plane3;
                Frequency.GetComponent<Image>().sprite = plane3;
                Gain.GetComponent<Image>().sprite = plane3;
                Rotation.GetComponent<Image>().sprite = plane3;
                Clear.GetComponent<Image>().sprite = plane3;
                NULL.GetComponent<Image>().sprite = plane3;
                Store_Button.GetComponent<Image>().sprite = plane3;
                Display.GetComponent<Image>().sprite = plane3;
                imgNumberCount++;
                break;

            case 2:
                Channel.GetComponent<Image>().sprite = plane4;
                Frequency.GetComponent<Image>().sprite = plane4;
                Gain.GetComponent<Image>().sprite = plane4;
                Rotation.GetComponent<Image>().sprite = plane4;
                Clear.GetComponent<Image>().sprite = plane4;
                NULL.GetComponent<Image>().sprite = plane4;
                Store_Button.GetComponent<Image>().sprite = plane4;
                Display.GetComponent<Image>().sprite = plane4;
                imgNumberCount++;
                break;

            case 3:
                Channel.GetComponent<Image>().sprite = plane5;
                Frequency.GetComponent<Image>().sprite = plane5;
                Gain.GetComponent<Image>().sprite = plane5;
                Rotation.GetComponent<Image>().sprite = plane5;
                Clear.GetComponent<Image>().sprite = plane5;
                NULL.GetComponent<Image>().sprite = plane5;
                Store_Button.GetComponent<Image>().sprite = plane5;
                Display.GetComponent<Image>().sprite = plane5;
                imgNumberCount++;
                break;

            case 4:
                Channel.GetComponent<Image>().sprite = plane6;
                Frequency.GetComponent<Image>().sprite = plane6;
                Gain.GetComponent<Image>().sprite = plane6;
                Rotation.GetComponent<Image>().sprite = plane6;
                Clear.GetComponent<Image>().sprite = plane6;
                NULL.GetComponent<Image>().sprite = plane6;
                Store_Button.GetComponent<Image>().sprite = plane6;
                Display.GetComponent<Image>().sprite = plane6;
                imgNumberCount++;
                break;

            case 5:
                Channel.GetComponent<Image>().sprite = plane7;
                Frequency.GetComponent<Image>().sprite = plane7;
                Gain.GetComponent<Image>().sprite = plane7;
                Rotation.GetComponent<Image>().sprite = plane7;
                Clear.GetComponent<Image>().sprite = plane7;
                NULL.GetComponent<Image>().sprite = plane7;
                Store_Button.GetComponent<Image>().sprite = plane7;
                Display.GetComponent<Image>().sprite = plane7;
                imgNumberCount++;
                break;

            case 6:
                Channel.GetComponent<Image>().sprite = plane8;
                Frequency.GetComponent<Image>().sprite = plane8;
                Gain.GetComponent<Image>().sprite = plane8;
                Rotation.GetComponent<Image>().sprite = plane8;
                Clear.GetComponent<Image>().sprite = plane8;
                NULL.GetComponent<Image>().sprite = plane8;
                Store_Button.GetComponent<Image>().sprite = plane8;
                Display.GetComponent<Image>().sprite = plane8;
                //change color of text to match boarder
                ChannelText.GetComponent<Text>().color = Color.green;
                FrequencyText1.GetComponent<Text>().color = Color.green;
                FrequencyText2.GetComponent<Text>().color = Color.green;
                FrequencyText3.GetComponent<Text>().color = Color.green;
                GainText1.GetComponent<Text>().color = Color.green;
                GainText2.GetComponent<Text>().color = Color.green;
                GainText3.GetComponent<Text>().color = Color.green;
                GainText4.GetComponent<Text>().color = Color.green;
                GainText5.GetComponent<Text>().color = Color.green;
                GainText6.GetComponent<Text>().color = Color.green;
                GainText7.GetComponent<Text>().color = Color.green;
                RotationText.GetComponent<Text>().color = Color.green;
                ClearText.GetComponent<Text>().color = Color.green;
                NULLText.GetComponent<Text>().color = Color.green;
                Store_ButtonText.GetComponent<Text>().color = Color.green;
                DisplayText.GetComponent<Text>().color = Color.green;
                imgNumberCount++;
                break;

            case 7:
                Channel.GetComponent<Image>().sprite = plane9;
                Frequency.GetComponent<Image>().sprite = plane9;
                Gain.GetComponent<Image>().sprite = plane9;
                Rotation.GetComponent<Image>().sprite = plane9;
                Clear.GetComponent<Image>().sprite = plane9;
                NULL.GetComponent<Image>().sprite = plane9;
                Store_Button.GetComponent<Image>().sprite = plane9;
                Display.GetComponent<Image>().sprite = plane9;
                //change color of text to match boarder
                ChannelText.color = new Color(1f, 0.309f, 0f);
                FrequencyText1.color = new Color(1f, 0.309f, 0f);
                FrequencyText2.color = new Color(1f, 0.309f, 0f);
                FrequencyText3.color = new Color(1f, 0.309f, 0f);
                GainText1.color = new Color(1f, 0.309f, 0f);
                GainText2.color = new Color(1f, 0.309f, 0f);
                GainText3.color = new Color(1f, 0.309f, 0f);
                GainText4.color = new Color(1f, 0.309f, 0f);
                GainText5.color = new Color(1f, 0.309f, 0f);
                GainText6.color = new Color(1f, 0.309f, 0f);
                GainText7.color = new Color(1f, 0.309f, 0f);
                RotationText.color = new Color(1f, 0.309f, 0f);
                ClearText.color = new Color(1f, 0.309f, 0f);
                NULLText.color = new Color(1f, 0.309f, 0f);
                Store_ButtonText.color = new Color(1f, 0.309f, 0f);
                DisplayText.color = new Color(1f, 0.309f, 0f);
                imgNumberCount++;
                break;

            case 8:
                Channel.GetComponent<Image>().sprite = plane3;
                Frequency.GetComponent<Image>().sprite = plane1;
                Gain.GetComponent<Image>().sprite = plane7;
                Rotation.GetComponent<Image>().sprite = plane2;
                Clear.GetComponent<Image>().sprite = plane10;
                NULL.GetComponent<Image>().sprite = plane4;
                Store_Button.GetComponent<Image>().sprite = plane5;
                Display.GetComponent<Image>().sprite = plane6;
                //return color of text to black
                ChannelText.GetComponent<Text>().color = Color.black;
                FrequencyText1.GetComponent<Text>().color = Color.black;
                FrequencyText2.GetComponent<Text>().color = Color.black;
                FrequencyText3.GetComponent<Text>().color = Color.black;
                GainText1.GetComponent<Text>().color = Color.black;
                GainText2.GetComponent<Text>().color = Color.black;
                GainText3.GetComponent<Text>().color = Color.black;
                GainText4.GetComponent<Text>().color = Color.black;
                GainText5.GetComponent<Text>().color = Color.black;
                GainText6.GetComponent<Text>().color = Color.black;
                GainText7.GetComponent<Text>().color = Color.black;
                RotationText.GetComponent<Text>().color = Color.black;
                ClearText.GetComponent<Text>().color = Color.black;
                NULLText.GetComponent<Text>().color = Color.black;
                Store_ButtonText.GetComponent<Text>().color = Color.black;
                DisplayText.GetComponent<Text>().color = Color.black;
                imgNumberCount++;
                break;

            case 9:
                Channel.GetComponent<Image>().sprite = plane1;
                Frequency.GetComponent<Image>().sprite = plane1;
                Gain.GetComponent<Image>().sprite = plane1;
                Rotation.GetComponent<Image>().sprite = plane1;
                Clear.GetComponent<Image>().sprite = plane1;
                NULL.GetComponent<Image>().sprite = plane1;
                Store_Button.GetComponent<Image>().sprite = plane1;
                Display.GetComponent<Image>().sprite = plane1;
                imgNumberCount = 0;
                break;

            default:
                Debug.Log("colorChange error");
                break;

        }


    }
}
