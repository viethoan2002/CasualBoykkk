using Assets.Scripts.Player.Ability;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSpeedUpAbility : BaseButton
{
    private string nameAbility = "SpeedUp";
    public override void OnClick()
    {
        GetPlayerAbility();
        ResumeGame();
    }

    private void ResumeGame()
    {
        MapManager.instance.OnResume();
        AbilityInventory.intance.Close();
    }

    private void GetPlayerAbility()
    {
        var playerAbilityFactory = new PlayerAbilityFactory();
        playerAbilityFactory.GetAbility(nameAbility).process();
    }
}
