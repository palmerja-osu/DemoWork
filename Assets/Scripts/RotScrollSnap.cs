using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RotScrollSnap : MonoBehaviour
{
    static ScrollRect scrollRect;
    public ScrollRect myScrollRect;
    public RectTransform scrollableContent;
    public OptionsStats OptionStats;



    //Do this when the Save button is selected.
    public void Start()
    {
        // assigns the contect that can be scrolled using the ScrollRect.
        myScrollRect.content = scrollableContent;


        scrollRect = GetComponent<ScrollRect>();
        scrollRect.onValueChanged.AddListener(ListenerMethod);

    }

    public void ListenerMethod(Vector2 value)
    {

        Debug.Log("ListenerMethod: " + value);
        //send value to options stats
        //OptionStats.rotValue(value);
    }

}