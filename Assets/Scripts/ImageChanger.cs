using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    public Sprite spriteToChangeTo;

    public void ChangeImage(Image myImageToUpdate)
    {
        myImageToUpdate.sprite = spriteToChangeTo;
    }
}