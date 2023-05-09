using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStarter : MonoBehaviour
{
    public void OnRetry()
    {
        GameManager.DataClear();
        SceneManager.LoadScene(0);
    }

}
