using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isLive;
    public static int score;
    public static int health = 3;
    public static int level;
    public static Material skin;

    void Awake()
    {
        if (!PlayerPrefs.HasKey("Score"))
            PlayerPrefs.SetInt("Score", 0);

    }
    public static void GameStart()
    {
        isLive = true;
        Next();
    }
    public static void GameOver()
    {
        SceneManager.LoadScene("End");
        int curScore = PlayerPrefs.GetInt("Score");
        PlayerPrefs.SetInt("Score", Mathf.Max(curScore, score));
    }
    public static void DataClear()
    {
        isLive = false;
        score = 0;
        health = 3;
        level = 0;
}

public static void GetItem()
    {
        score += 100;
    }
    public static void Hit()
    {
        health--;
        if (health == 0)
            GameOver();
    }
    public static void Next()
    {
        level++;
        //간단한 if문 삼항연산자 활용
        score += ((level > 1) ? 1000 : 0);
        //SceneManager.LoadScene(level < 4 ? "Game" : "End");
        if (level < 4)
            SceneManager.LoadScene("Game");
        else
            GameOver();
    } 
}
