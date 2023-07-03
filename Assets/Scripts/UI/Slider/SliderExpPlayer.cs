using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderExpPlayer : MonoBehaviour
{
    [SerializeField] private LevelController levelController;
    private Slider slider;
    private void Start()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        levelController = GameObject.Find("MapManager").GetComponent<LevelController>();
        this.slider = this.GetComponent<Slider>();
    }

    public void SetSliderExp()
    {
        slider.value = levelController.GetCurrentExp();
    }

    private void OnEnable()
    {
        LevelController.OnAddExp += SetSliderExp;
    }
    private void OnDisable()
    {
        LevelController.OnAddExp -= SetSliderExp;
    }
}
