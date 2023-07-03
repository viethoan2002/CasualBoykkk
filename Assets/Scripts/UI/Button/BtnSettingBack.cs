using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSettingBack : BaseButton
{
    public override void OnClick()
    {
        MenuInventory.intance.Open();
        SettingInventory.intance.Close();
    }
}
