using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSetting : BaseButton
{
    public override void OnClick()
    {
        SettingInventory.intance.Open();
        MenuInventory.intance.Close();
    }
}
