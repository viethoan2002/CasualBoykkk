using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInventory : Inventory
{
    public static MenuInventory intance;
    private void Start()
    {
        MenuInventory.intance = this;
        this.Open();
    }
}
