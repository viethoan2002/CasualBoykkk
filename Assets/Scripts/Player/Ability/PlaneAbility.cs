using Assets.Scripts.Player.Ability;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAbility : PlayerAbility
{

    public virtual void process()
    {
        var planeAbilityCtrl = GameObject.Find("PlaneAbility").GetComponent<PlaneAbilityCtrl>();
        planeAbilityCtrl.StartBomb();
    }

}

