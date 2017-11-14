using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OptionsStats : MonoBehaviour
{

    public static double Frequency;
    public double startFrequency = 2.0;

    public static double Gain;
    public double startGain = 36.0;

    public static double HGain;
    public double startHGain = 42.0;

    public static double VGain;
    public double startVGain = 36.0;

    public static double Rotation;
    public double startRotation = 180;


    void Start()
    {
        Frequency = startFrequency;
        Gain = startGain;
        HGain = startHGain;
        VGain = startVGain;
        Rotation = startRotation;

    }


}
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


//public class OptionsStats : MonoBehaviour
//{

//    public static double Frequency = 1.0;
//    //public double startFrequency = 2.0;

//    public static double Gain;
//   // public double startGain = 36.0;

//    public static double HGain;
//    //public double startHGain = 42.0;

//    public static double VGain;
//    //public double startVGain = 36.0;

//    public static double Rotation;
//    //public double startRotation = 180;

//    void Start()
//    {

//        freqValue();
//        gainValue();
//        hGainValue();
//        vGainValue();
//        rotValue(Rotation);
//        //Frequency = rotValue(x);
//        //Gain = startGain;
//        //HGain = startHGain;
//        //VGain = startVGain;
//        //Rotation = startRotation;

//    }

//    public void freqValue()
//    {

//    }
//    public void gainValue()
//    {

//    }
//    public void hGainValue()
//    {

//    }
//    public void vGainValue()
//    {

//    }
//    public void rotValue(Vector2 x)
//    {


//        Vector2 size = new Vector2("Content", x);

//        x.SetDouble("Content", x);
//        x = startRotation;

//    }


//}
