using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderVolume : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private void Start()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        slider = GetComponent<Slider>();
        var volume = PlayerPrefs.GetFloat("Volume");
        slider.value=volume;
        this.slider.onValueChanged.AddListener(ValueChange);
    }


    private void ValueChange(float arg0)
    {
        PlayerPrefs.SetFloat("Volume", arg0);
    }
}
