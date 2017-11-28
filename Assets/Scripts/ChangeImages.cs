using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeImages : MonoBehaviour
{

    public Sprite plane1; // I attched these from editor
    public Sprite plane2;
    public Sprite plane3;
    public Sprite plane4;
    public Sprite plane5;

    public Text_Overlay Text_Overlay;

    public int imgNumberCount;


    public void changeImages() // make sure to attach this to event trigger
    {
        switch (imgNumberCount)
        {

            case 0:
                imgNumberCount = 0;
                GetComponent<Image>().sprite = plane1;
                string message1 = "F1/DIFF: ";
                Text_Overlay.freqPlaneText(message1);
                imgNumberCount++; //increase count so it gets higher and switches to different sprite
                break;
            case 1:
                GetComponent<Image>().sprite = plane2;
                string message2 = "F2/DIFF: ";
                Text_Overlay.freqPlaneText(message2);
                imgNumberCount++;
                break;
            case 2:
                GetComponent<Image>().sprite = plane3;
                string message3 = "F3/DIFF:";
                Text_Overlay.freqPlaneText(message3);
                imgNumberCount++;
                break;
            case 3:
                GetComponent<Image>().sprite = plane4;
                string message4 = "F4/DIFF: ";
                Text_Overlay.freqPlaneText(message4);
                imgNumberCount++;
                imgNumberCount = 0; //set back to first image
                break;

            default:
                Debug.Log("Error");
                break;
        }
    }

    public void ClearButtonimgCount()
    {
        //when clear button is pressed set image to empty plane5
        GetComponent<Image>().sprite = plane5;
        imgNumberCount = 0;
        string message5 = "F0/DIFF";
        Text_Overlay.freqPlaneText(message5);
    }
}
