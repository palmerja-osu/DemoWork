using System.Collections;
using UnityEngine.UI;
using UnityEngine;


public class NullMenu : MonoBehaviour {

    public ChangeImages changeImage;

    public void PressedNullButton()
    {
        Debug.Log("pressed null button");
    }
    public void PressedClearButton()
    {
        Debug.Log("pressed clear button");
    }
    public void PressedDisplayButton()
    {

        changeImage.changeImages();
        Debug.Log("pressed display button");
    }
}

