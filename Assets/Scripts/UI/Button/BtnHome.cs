using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnHome : BaseButton
{
    public override void OnClick()
    {
        SceneManager.LoadScene("Home");
        MapManager.instance.OnResume();
    }
}
