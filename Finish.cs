using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //스테이지 이동
            GameManager.Next();
            //플레이어 원위치
            other.transform.position = Vector3.up * 2;
        }
    }
}
