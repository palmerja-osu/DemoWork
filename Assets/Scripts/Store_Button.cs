using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store_Button : MonoBehaviour {

    public GameObject imageStore;
    private string myText = "Scene has been saved!";   // Assign the text to this in the inspector

    public void StartCoroutine()
    {
        imageStore.SetActive(true); // Enable the text so it shows
        StartCoroutine(WaitScreen());
    }

    IEnumerator WaitScreen()
    {
        
        print(myText); //print my text
        yield return new WaitForSeconds(2); //wait 2 seconds
        imageStore.SetActive(false); // Disable the text so it is hidden

       
    }
}
