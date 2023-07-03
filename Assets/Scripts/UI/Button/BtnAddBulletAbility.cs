using Assets.Scripts.Player.Ability;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnAddBulletAbility : BaseButton
{
    private string nameAbility = "AddBullet";
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
