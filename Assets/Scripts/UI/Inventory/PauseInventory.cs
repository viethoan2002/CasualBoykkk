using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseInventory : Inventory
{
    public static PauseInventory intance;
    private void Start()
    {
        PauseInventory.intance = this;
        this.Close();
    }
}

