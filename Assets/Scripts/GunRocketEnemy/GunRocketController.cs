using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRocketController : MonoBehaviour
{
    [SerializeField] private SpawnInTime spawn;
    [SerializeField] private PlayerController playerController;

    private void Start()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        playerController = GameObject.Find("PlayerCtrl").GetComponent<PlayerController>();
    }

    private void Awake()
    {
        playerController = GameObject.Find("PlayerCtrl").GetComponent<PlayerController>();
    }

}
