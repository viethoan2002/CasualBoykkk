using Assets.Scripts.Player.Ability;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPlaneAbility : BaseButton
{
    private string nameAbility = "Plane";
    private bool isReady = true;

    private void OnEnable()
    {
        PlaneCountDown.PlaneReady += SetReady;
    }

    private void SetReady()
    {
        isReady = true;
    }

    public override void OnClick()
    {
        if (isReady) 
        { 
           GetPlayerAbility();
        }
        isReady = false;
    }

    private void GetPlayerAbility()
    {
        var playerAbilityFactory = new PlayerAbilityFactory();
        playerAbilityFactory.GetAbility(nameAbility).process();
    }
}
