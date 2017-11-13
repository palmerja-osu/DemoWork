using System.Collections;
using UnityEngine.UI;
using UnityEngine;


public class NullMenu : MonoBehaviour {

    public ChangeImage ChangeImage;

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

        ChangeImage.changeImages();
        Debug.Log("pressed display button");
    }
}

