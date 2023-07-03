using Assets.Scripts.Player.Ability;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBulletAbility : PlayerAbility
{

    public virtual void process()
    {
        var playerGunCtrl = GameObject.Find("PlayerGun").GetComponent<GunPlayerController>();
        playerGunCtrl.gunPlayerManager.AddBullet();
    }

}