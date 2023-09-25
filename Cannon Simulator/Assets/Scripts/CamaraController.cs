using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public List<Transform> cameraPos;
    public int currentPos = 0;

    public void CameraSwap()
    {
        currentPos++;
        if (currentPos >= 6) { currentPos = 0; }
        transform.position = cameraPos[currentPos].position;
        transform.rotation = cameraPos[currentPos].rotation;
    }
}
