using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInventory : Inventory
{
    public static LevelInventory intance;
    private void Start()
    {
        LevelInventory.intance = this;
        this.Close();
    }
}
