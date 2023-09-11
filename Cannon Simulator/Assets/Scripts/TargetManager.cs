using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetManager : MonoBehaviour
{
    public Text targetText;
    public int Counter;

    void TargetText()
    {
        Counter++;
        targetText.text = "TARGETS HIT: " + Counter;
    }

    private void OnEnable()
    {
        Target.targetEvent += TargetText;
    }

    private void OnDisable()
    {
        Target.targetEvent -= TargetText;
    }
}
