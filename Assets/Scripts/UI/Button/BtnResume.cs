using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnResume : BaseButton
{
    [SerializeField] private GameObject pauseButton;
    public override void OnClick()
    {
        pauseButton.SetActive(true);
        MapManager.instance.OnResume();
        PauseInventory.intance.Close();
    }
}
