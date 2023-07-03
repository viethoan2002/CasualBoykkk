using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinInventory : Inventory
{
    public static WinInventory intance;
    private void Start()
    {
        WinInventory.intance = this;
        this.Close();
    }
}
