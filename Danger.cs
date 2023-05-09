using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            //����� ����
            GameManager.Hit();
            //����
            other.SendMessage("PlaySound", Sounder.Sfx.Hit);

            //�÷��̾� ����ġ
            other.transform.position = Vector3.up * 2;
    }

}
