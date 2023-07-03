using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnStart : BaseButton
{
    public override void OnClick()
    {
        LevelInventory.intance.Open();
        MenuInventory.intance.Close();
    }
}
