using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlane : MonoBehaviour {

    public Options_Menu Options_Menu;
    public Text_Overlay Text_Overlay;

    private float baseAngle = 0.0f;


    public void updateRot(string keypadRot)
    {
        //send updates to menu and overlay
        Options_Menu.rotOutput(keypadRot);
        Text_Overlay.rotOutput(keypadRot);


        ////convert string to Vector3
        //if (keypadRot.StartsWith("") && keypadRot.EndsWith(""))
        //{
        //    keypadRot = keypadRot.Substring(1, keypadRot.Length - 2);
        //}

        //// split the items
        //string[] sArray = keypadRot.Split(',');

        //// store as a Vector3
        //Vector3 result = new Vector3(
        //    float.Parse(sArray[0]),
        //    float.Parse(sArray[1]),
        //    float.Parse(sArray[2]));

     
       
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        pos = Input.mousePosition - pos;
       // pos = result; //set reult of string to new Vector3 as pos
        float ang = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - baseAngle;
        
        
        transform.rotation = Quaternion.AngleAxis(ang, Vector3.forward);

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
        


        string rotationOutput = ang.ToString("F0");
        //Debug.Log(rotationOutput);
        Options_Menu.rotOutput(rotationOutput);
        Text_Overlay.rotOutput(rotationOutput);
    }

    


}