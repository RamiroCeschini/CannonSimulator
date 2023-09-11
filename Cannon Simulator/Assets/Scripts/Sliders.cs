using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliders : MonoBehaviour
{
    public float cannonBallWeight = 1;
    public float cannonForce = 100;
    public GameObject CannonBarrel;

    private void Start()
    {
        BarrelRotationX(0f);
        BarrelRotationY(0f);
        CannonBallWeight(0.2f);
        CannonForce(0.5f);
    }

    public void BarrelRotationX(float rotationX)
    {
        CannonBarrel.transform.localEulerAngles = new Vector3(CannonBarrel.transform.localEulerAngles.x, rotationX * 70, CannonBarrel.transform.localEulerAngles.z);
    }

    public void BarrelRotationY(float rotationY)
    {
        CannonBarrel.transform.localEulerAngles = new Vector3(-rotationY * 35, CannonBarrel.transform.localEulerAngles.y, CannonBarrel.transform.localEulerAngles.z);
    }

    public void CannonBallWeight(float weight)
    {
        cannonBallWeight = weight * 10 + 1;
        Debug.Log(cannonBallWeight);
    }

    public void CannonForce(float force)
    {
        cannonForce = force * 650 + 100;
        Debug.Log(cannonForce);
    }
}
