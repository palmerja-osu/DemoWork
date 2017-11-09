using System.Collections;
using UnityEngine.UI;
using UnityEngine;


public class NullMenu : MonoBehaviour {

    public Display_Swap Display_Swap;
    

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
        Display_Swap.Update();
        Debug.Log("pressed display button");
    }
}

