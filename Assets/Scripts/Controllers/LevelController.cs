using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : Singleton<LevelController>
{
    public int Level
    {
        get =>  PlayerPrefs.GetInt("Level");
        set => PlayerPrefs.SetInt("Level",value);
    }

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Level"))
        {
            Level = 1;
        }
    }

    public void LevelLoad()
    {
        SceneManager.LoadScene(Level);
    }
}
