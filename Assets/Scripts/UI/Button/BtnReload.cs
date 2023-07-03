using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnReload : BaseButton
{
    public override void OnClick()
    {
        MapManager.instance.ReloadScene();
    }
}
