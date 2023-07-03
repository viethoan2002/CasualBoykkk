using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPlayerController : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    public GunPlayerManager gunPlayerManager;
    // Start is called before the first frame update
    private void Awake()
    {
       // playerController.playerHealth.OnDie += ResetGunPlayer;
    }

    private void OnEnable()
    {
        PlayerHealth.OnDie += ResetGunPlayer;
    }

    private void ResetGunPlayer()
    {
       //
    }
}
