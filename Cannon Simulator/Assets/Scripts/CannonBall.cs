using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    public Rigidbody rb;
    public float CBSpeed;
    public LastShot lastShotInfo;
    public Sliders sliderInfo;
    public TargetManager hitsInfo;
    public float startCounter;
    public float endCounter;

    public float startX;
    public float startY;
    public float startWeight;
    public float startForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lastShotInfo = GameObject.FindGameObjectWithTag("LastShot").GetComponent<LastShot>();
        sliderInfo = GameObject.FindGameObjectWithTag("Slider").GetComponent<Sliders>();
        hitsInfo = GameObject.FindGameObjectWithTag("Hits").GetComponent<TargetManager>();
        rb.AddRelativeForce(0f, 0f,CBSpeed,ForceMode.Impulse);
        Invoke("DestroyBall", 7f);
        startCounter = hitsInfo.Counter;

        startX = sliderInfo.currentX;
        startY = sliderInfo.currentY;
        startWeight = sliderInfo.cannonBallWeight;
        startForce = sliderInfo.cannonForce;
    }

    void DestroyBall()
    {
        endCounter = hitsInfo.Counter;
        lastShotInfo.WriteLS(startX, startY, startWeight, startForce, endCounter - startCounter);
        Destroy(gameObject);
        sliderInfo.canShoot = true;
    }

}
