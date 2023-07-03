using Assets.Scripts.Player.Ability;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpAbility : PlayerAbility
{

    public virtual void process()
    {
        var playerCtrl = GameObject.Find("PlayerCtrl").GetComponent<PlayerController>();
        playerCtrl.playerMove.setSpeed(1.5f);
    }

}
