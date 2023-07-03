using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSliderHP : MonoBehaviour
{
    [SerializeField] private Slider playerHP;
    [SerializeField] private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetSlideHP();
    }

    private void SetSlideHP()
    {
        var currenthealth = playerController.playerHealth.GetCurrentHealth();
        var maxhealth = playerController.playerHealth.GetMaxHealth();
        playerHP.value = currenthealth/maxhealth;
    }
}
