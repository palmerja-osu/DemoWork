using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keypadNum : MonoBehaviour {

    public GameObject keypad;

    void OnMouseDown()
    {
        
        keypad.GetComponent<Keypad_Code>().receiveSignal(gameObject);
    }
}
