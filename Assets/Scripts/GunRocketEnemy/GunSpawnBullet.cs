using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSpawnBullet : MonoBehaviour
{
    [SerializeField] private SpawnInTime spawn;
    [SerializeField] private GameObject prefObject;
    [SerializeField] private Transform InstatePosition;

    private void Awake()
    {
        spawn.InstateObject += InstateEnemyBullet;
    }

    private void InstateEnemyBullet()
    {
        Instantiate(prefObject, InstatePosition.position, transform.rotation);
    }
}
