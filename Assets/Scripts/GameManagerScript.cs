using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    GameObject[] pause;

    void Start()
    {
        pause = GameObject.FindGameObjectsWithTag("pause");
        foreach (GameObject pauobj in pause)
        {
            pauobj.SetActive(false);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        foreach (GameObject pauobj in pause)
        {
            pauobj.SetActive(true);
        }
    }

    public void UnPause()
    {
        Time.timeScale = 1;
        foreach (GameObject pauobj in pause)
        {
            pauobj.SetActive(false);
        }

    }
}