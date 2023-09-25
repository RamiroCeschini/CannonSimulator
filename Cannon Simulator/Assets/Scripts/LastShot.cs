using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastShot : MonoBehaviour
{
    public Text lStext;
    public float lastX;
    public float lastY;
    public float lastWeight;
    public float lastForce;

    public void WriteLS(float X,float Y, float Weight, float Force, float TargetsHit)
    {
        lastX = X;
        lastY = Y;
        lastWeight = Weight;
        lastForce = Force;
        lStext.text = "Last Shot: " + "X: " + X + "° Y: " + Y + "° Weight: " + Weight + "kg Force: " + Force + "N Targets Hit: "+ TargetsHit;
    }
}
