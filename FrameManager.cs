using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameManager : MonoBehaviour
{
    [Range(1, 144)]
    public int rate = 60;
    void Start()
    {
        Application.targetFrameRate = rate;
    }
}
