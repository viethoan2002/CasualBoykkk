using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAction : MonoBehaviour
{
    [SerializeField] private Transform PlayerPosition;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private SpawnInTime spawn;

    private void Awake()
    {
        playerController = GameObject.Find("PlayerCtrl").GetComponent<PlayerController>();
        //playerController.playerHealth.OnDie += spawn.PauseSpawn;
        //playerController.playerHealth.OnRevival += spawn.ResumeSpawn;
    }

    private void Update()
    {
        transform.LookAt(PlayerPosition);
    }

    private void OnEnable()
    {
        PlayerHealth.OnDie += spawn.PauseSpawn;
        PlayerHealth.OnRevival += spawn.ResumeSpawn;
    }
}
