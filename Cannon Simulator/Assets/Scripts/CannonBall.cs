using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    public Rigidbody rb;
    public float CBSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Random.Range(-10,10), 0f,CBSpeed,ForceMode.Impulse);
        Invoke("DestroyBall", 15f);
    }

    public void SetWeight(float weight)
    {
        rb.mass = weight;
    }

    void DestroyBall()
    {
        Destroy(gameObject);
    }

}
