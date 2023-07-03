using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderHpPlayer : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Slider sliderHP;
    private void Start()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        playerController = GameObject.Find("PlayerCtrl").GetComponent<PlayerController>();
        sliderHP = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        PlayerHealth.OnTakeDamage += SetSliderHP;
    }

    private void OnDisable()
    {
        PlayerHealth.OnTakeDamage -= SetSliderHP;
    }

    private void SetSliderHP()
    {
        Debug.Log(playerController);
        var currenthealth = playerController.playerHealth.GetCurrentHealth();

        if (currenthealth < 0)
        {
            currenthealth = 0;
        }
        var maxhealth = playerController.playerHealth.GetMaxHealth();

        sliderHP.value = currenthealth/maxhealth;
    }
}
