using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private bool beenHit = false;
    public delegate void TargetEvent();
    public static TargetEvent targetEvent;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CannonBall") || collision.gameObject.CompareTag("Target"))
        {
            TargetHit();
            Debug.Log("beenhit");
        }
    }

    private void TargetHit()
    {
        if (!beenHit)
        {
            beenHit = true;
            targetEvent?.Invoke();
            Debug.Log("evento");
        }
    }
}
