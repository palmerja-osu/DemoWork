using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class contentScrollRect : MonoBehaviour
{
    public ScrollRect myScrollRect;
    public RectTransform scrollableContent;

    //Do this when the Save button is selected.
    public void Start()
    {
        // assigns the contect that can be scrolled using the ScrollRect.
        myScrollRect.content = scrollableContent;
    }
}