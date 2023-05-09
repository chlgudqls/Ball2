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

    //UI는 lateupdate에서 한다고했었음
    void LateUpdate()
    {
        switch(uiType)
        {
            case Info.Level:
                //문자열 더해주면 암묵적으로 형변환까지해줌
                myText.text = "스테이지 " + GameManager.level;
                break;
            case Info.Score:
                //0은 인덱스 중괄호안에 ,뒤의 값이 매개변수로 들어감
                myText.text = string.Format("점수 - {0:D3}", GameManager.score);
                break;
            case Info.Health:
                myText.text = "남은공 " + GameManager.health + "개";
                break;
            case Info.HighScore:
                myText.text = "최고점수 " + PlayerPrefs.GetInt("Score");
                break;
        }
    }
}
