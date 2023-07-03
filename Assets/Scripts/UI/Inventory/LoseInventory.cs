using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseInventory : Inventory
{
    public static LoseInventory intance;
    private void Start()
    {
        LoseInventory.intance = this;
        this.Close();
    }
}
