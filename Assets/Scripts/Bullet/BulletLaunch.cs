using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLaunch : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject gunPlayer;
    private void Start()
    {
        gunPlayer = GameObject.Find("PlayerGun");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ActiveBullet();
            gameObject.tag = "Bullet";
        }
    }

    private void ActiveBullet()
    {
        gunPlayer.GetComponent<GunPlayerManager>().AddBullet();
        Destroy(gameObject);
    }
}
