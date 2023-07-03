using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSetUpPoint : MonoBehaviour
{
    [SerializeField] private Slider sliderExp;
    [SerializeField] private Transform handle;
    [SerializeField] private List<float> listCheckpoint;
    [SerializeField] private GameObject WinPoint;
    [SerializeField] GameObject ExpPoint;
    // Start is called before the first frame update
    void Start()
    {
        LoadComponent();
        SetUpPointPos();
        ResetValueSlider();
    }


    private void LoadComponent()
    {
        sliderExp = GetComponent<Slider>();
        var levelCtrl = GameObject.Find("MapManager").GetComponent<LevelController>();
        listCheckpoint = levelCtrl.GetListCheckPoint();
    }
    private void SetUpPointPos()
    {
        SetUpPos(Instantiate(WinPoint), 1);
        foreach(var i in listCheckpoint)
        {
            SetUpPos(Instantiate(ExpPoint), i);
        }
    }
    private void SetUpPos(GameObject point,float value)
    {
        sliderExp.value = value;
        point.transform.position = handle.transform.position;
    }
    private void ResetValueSlider()
    {
        sliderExp.value = 0;
    }

    
}
