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
            //점수 얻기
            GameManager.GetItem();
            //사운드
            other.SendMessage("PlaySound", Sounder.Sfx.Item);

            Destroy(gameObject);
        }
    }


}
