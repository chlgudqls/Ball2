using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;


public class Item : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //���� ���
            GameManager.GetItem();
            //����
            other.SendMessage("PlaySound", Sounder.Sfx.Item);

            Destroy(gameObject);
        }
    }


}
