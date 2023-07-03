using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPause : BaseButton
{
    public override void OnClick()
    {
        PauseInventory.intance.Open();
        MapManager.instance.OnPause();
        gameObject.SetActive(false);
    }
}
