using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
   // private bool beenHit = false;
    public delegate void TargetEvent();
    public static TargetEvent targetEvent;
    public FixedJoint joint;

    private void Start()
    {
        joint = GetComponent<FixedJoint>(); 
    }

    private void OnJointBreak()
    {
        targetEvent?.Invoke();
    }
}
