using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnAds : BaseButton
{
    public override void OnClick()
    {
        LevelPlayerAds.instance.ShowRewardAds();
    }
    private void OnEnable()
    {
        LevelPlayerAds.OnReward += ResumeGame;
    }

    private void ResumeGame()
    {
        MapManager.instance.OnResume();
        LoseInventory.intance.Close();
    }
}
