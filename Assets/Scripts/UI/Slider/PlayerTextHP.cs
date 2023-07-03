using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerTextHP : MonoBehaviour
{
    [SerializeField] private TMP_Text playerHP;
    [SerializeField] private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        playerController = GameObject.Find("PlayerCtrl").GetComponent<PlayerController>();
    }

    private void OnEnable()
    {
        PlayerHealth.OnTakeDamage += SetTextHP;
    }

    private void OnDisable()
    {
        PlayerHealth.OnTakeDamage -= SetTextHP;
    }

    // Update is called once per frame
    void SetTextHP()
    {
        var currenthealth = playerController.playerHealth.GetCurrentHealth();

        if (currenthealth < 0)
        {
            currenthealth = 0;
        }
        var maxhealth = playerController.playerHealth.GetMaxHealth();

        playerHP.text = $"{currenthealth}:{maxhealth}";
    }
}
