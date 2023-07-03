using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public static MapManager instance;
    [SerializeField] private string CurrentNameScene;
    [SerializeField] private string NextNameScene ;

    private void Awake()
    {
        MapManager.instance = this;
    }


    public void OnPause()
    {
        Time.timeScale = 0;
    }

    public void OnResume()
    {
        Time.timeScale = 1;
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(CurrentNameScene);
    }

    public void NextScene()
    {
        OnResume();
        SceneManager.LoadScene(NextNameScene);
    }

    public void UnlockNextScene()
    {
        PlayerPrefs.SetInt(NextNameScene, 1);
    }
}
