using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders : MonoBehaviour
{
    public float cannonBallWeight;
    public float cannonForce;
    public float currentX;
    public float currentY;
    public GameObject CannonBarrel;
    public Text rotXText;
    public Text rotYText;
    public Text weightText;
    public Text forceText;

    public bool canShoot = true;

    private void Start()
    {
        BarrelRotationX(0f);
        BarrelRotationY(0f);
        CannonBallWeight(0f);
        CannonForce(0f);
    }

    public void BarrelRotationX(float rotationX)
    {
        CannonBarrel.transform.localEulerAngles = new Vector3(CannonBarrel.transform.localEulerAngles.x, rotationX , CannonBarrel.transform.localEulerAngles.z);
        rotXText.text = rotationX.ToString() + "°";
        currentX = rotationX;
    }

    public void BarrelRotationY(float rotationY)
    {
        CannonBarrel.transform.localEulerAngles = new Vector3(-rotationY, CannonBarrel.transform.localEulerAngles.y, CannonBarrel.transform.localEulerAngles.z);
        rotYText.text = rotationY.ToString() + "°";
        currentY = rotationY;
    }

    public void CannonBallWeight(float weight)
    {
        cannonBallWeight = weight * 0.2f + 8;
        weightText.text = cannonBallWeight.ToString() + " kg";
    }

    public void CannonForce(float force)
    {
        cannonForce = force + 100;
        forceText.text = cannonForce.ToString() + " N";
    }
}
