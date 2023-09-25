using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
   public bool beenHit = false;
    public bool isJoint = false;
    public delegate void TargetEvent();
    public static TargetEvent targetEvent;


    private void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.CompareTag("CannonBall") && !beenHit && !isJoint)
        {
            targetEvent?.Invoke();
            beenHit = true;
        }
    }

    private void OnJointBreak()
    {
        targetEvent?.Invoke();
    }
}
