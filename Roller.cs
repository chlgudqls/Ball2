using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{
    public float speed;
    public bool isGlobal;

    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime,
            isGlobal? Space.World : Space.Self);
    }
}
