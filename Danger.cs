using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            //생명력 감소
            GameManager.Hit();
            //사운드
            other.SendMessage("PlaySound", Sounder.Sfx.Hit);

            //플레이어 원위치
            other.transform.position = Vector3.up * 2;
    }

}
