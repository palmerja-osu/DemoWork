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
