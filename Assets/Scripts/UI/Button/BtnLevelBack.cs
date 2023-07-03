using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnLevelBack :BaseButton
{
    public override void OnClick()
    {
        MenuInventory.intance.Open();
        LevelInventory.intance.Close();
    }
}
