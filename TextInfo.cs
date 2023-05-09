using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInfo : MonoBehaviour
{
    public enum Info { Level, Score, Health, HighScore}
    public Info uiType;
    Text myText;
    
    void Awake()
    {
        myText = GetComponent<Text>();
    }

    //UI�� lateupdate���� �Ѵٰ��߾���
    void LateUpdate()
    {
        switch(uiType)
        {
            case Info.Level:
                //���ڿ� �����ָ� �Ϲ������� ����ȯ��������
                myText.text = "�������� " + GameManager.level;
                break;
            case Info.Score:
                //0�� �ε��� �߰�ȣ�ȿ� ,���� ���� �Ű������� ��
                myText.text = string.Format("���� - {0:D3}", GameManager.score);
                break;
            case Info.Health:
                myText.text = "������ " + GameManager.health + "��";
                break;
            case Info.HighScore:
                myText.text = "�ְ����� " + PlayerPrefs.GetInt("Score");
                break;
        }
    }
}
