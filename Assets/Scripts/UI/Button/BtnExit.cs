using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnExit : BaseButton
{
    public override void OnClick()
    {
        Application.Quit();
    }
}
