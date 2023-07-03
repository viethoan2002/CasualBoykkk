using Assets.Scripts.Player.Ability;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealSelfAbility : PlayerAbility { 

    public virtual void process()
    {
        var playerCtrl = GameObject.Find("PlayerCtrl").GetComponent<PlayerController>();
        playerCtrl.playerHealth.HealSelf(20);
    }

}
