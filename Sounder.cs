using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounder : MonoBehaviour
{
    public enum Sfx { Start, Next, Jump, Item, Hit }
    public AudioClip[] clips;
    AudioSource audios;
    void Awake()
    {
        audios = GetComponent<AudioSource>();
        //���⶧���� �ؽ�Ʈ���尡 ����
        PlaySound(GameManager.level > 1 ? Sfx.Next :Sfx.Start);
    }

    public void PlaySound(Sfx sfx)
    {
        audios.clip = clips[(int)sfx];
        audios.Play();
    }
}
