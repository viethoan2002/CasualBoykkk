using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingInventory : Inventory
{
    public static SettingInventory intance;
    private void Start()
    {
        SettingInventory.intance = this;
        this.Close();
    }
}
