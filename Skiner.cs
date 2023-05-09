using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skiner : MonoBehaviour
{
    void Start()
    {
        if(gameObject.CompareTag("Player"))
        {
            MeshRenderer mesh = gameObject.GetComponent<MeshRenderer>();
            mesh.material = GameManager.skin;
        }
    }

    public void OnSelect(Material mat)
    {
        GameManager.skin = mat;
        GameManager.GameStart();
    }
}
