using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ChangeImages : MonoBehaviour {

    
    public Image[] Images;
    public Button Display_button;

    int count = 0;

    void Awake()
    {
        Images = Resources.LoadAll<Image>("Images");
    }

    public void On_Click_Button()
    {
        count++;

        if(count == Images.Length)
        {
            count = 0;

        }

        Display_button.image = Images[count];

        
        
    }

}
