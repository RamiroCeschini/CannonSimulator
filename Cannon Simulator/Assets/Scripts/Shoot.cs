using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject cannonBallPrefab;
    public Transform spawnPoint;
    public Sliders sliderInfo;

    public void ShootBall()
    {
        GameObject cannonBall = cannonBallPrefab;
        cannonBall.GetComponent<Rigidbody>().mass = sliderInfo.cannonBallWeight;
        cannonBall.GetComponent<CannonBall>().CBSpeed = sliderInfo.cannonForce;
        Instantiate(cannonBall, spawnPoint.position, spawnPoint.rotation);

    }
}
