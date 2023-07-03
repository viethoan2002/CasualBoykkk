using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityInventory : Inventory
{
    public static AbilityInventory intance;
    private void Start()
    {
        AbilityInventory.intance = this;
        this.Close();
    }

}
