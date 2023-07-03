using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnNext : BaseButton
{
    public override void OnClick()
    {
        MapManager.instance.NextScene();
    }
}
