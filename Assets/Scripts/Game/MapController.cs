using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    private void Start()
    {
        MapManager.instance.OnResume();
    }
    private void OnEnable()
    {
        PlayerHealth.OnDie += LoseGame;
        LevelController.OnWin += WinGame;
        LevelController.OnLevelUp += LevelUp;
    }

    private void LevelUp()
    {
        MapManager.instance.OnPause();
        AbilityInventory.intance.Open();
    }

    private void WinGame()
    {
        MapManager.instance.OnPause();
        WinInventory.intance.Open();
        MapManager.instance.UnlockNextScene();
    }

    private void LoseGame()
    {
        MapManager.instance.OnPause();
        LoseInventory.intance.Open();
    }
}
