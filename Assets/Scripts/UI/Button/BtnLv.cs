using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnLv : BaseButton
{
    [SerializeField] private string nameSceneLevel;
    [SerializeField] private GameObject LockIcon;

    private void Awake()
    {
        PlayerPrefs.SetInt("Level_1", 1);
        if (PlayerPrefs.GetInt(nameSceneLevel) > 0 && LockIcon!=null)
           LockIcon.SetActive(false);
    }

    public override void OnClick()
    {
        if(PlayerPrefs.GetInt(nameSceneLevel)>0)
        SceneManager.LoadScene(nameSceneLevel);
    }
}
