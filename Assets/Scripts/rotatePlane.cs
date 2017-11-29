using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlane : MonoBehaviour {

    public Options_Menu Options_Menu;
    public Text_Overlay Text_Overlay;
    public Keypad_RotCode Keypad_RotCode;

    private float baseAngle = 0.0f;

    [SerializeField]
    float eulerAngX;
    [SerializeField]
    float eulerAngY;
    [SerializeField]
    float eulerAngZ;

    void Update()
    {

        eulerAngX = transform.localEulerAngles.x;
        eulerAngY = transform.localEulerAngles.y;
        eulerAngZ = transform.localEulerAngles.z;

    }

    public void updateRot(string keypadRot)
    {
        //send updates to menu and overlay
        Options_Menu.rotOutput(keypadRot);
        Text_Overlay.rotOutput(keypadRot);

        float keyPadUpdate = float.Parse(keypadRot);
        eulerAngZ = keyPadUpdate;

        transform.Rotate(eulerAngX, eulerAngY, eulerAngZ);
        

    }


    void OnMouseDown()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        pos = Input.mousePosition - pos;
        baseAngle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
        baseAngle -= Mathf.Atan2(transform.right.y, transform.right.x) * Mathf.Rad2Deg;
    }

    void OnMouseDrag()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        pos = Input.mousePosition - pos;
        float ang = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - baseAngle;
        transform.rotation = Quaternion.AngleAxis(ang, Vector3.forward);

        
        string rotationOutput = eulerAngZ.ToString("F0");

     
        Options_Menu.rotOutput(rotationOutput); //send touch update to options
        Text_Overlay.rotOutput(rotationOutput); //send touch update to overlay
        Keypad_RotCode.updateRotatePlane(rotationOutput); //update keypad with new touch
    }




}