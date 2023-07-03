using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private LevelController levelController;

    private void Awake()
    {
        LoadComponent();    
    }

    private void LoadComponent()
    {
        levelController = GameObject.Find("MapManager").GetComponent<LevelController>();
        playerController = GameObject.Find("PlayerCtrl").GetComponent<PlayerController>();
    }

    private void OnEnable()
    {
        PlayerHealth.OnDie += DesEnemy;
    }

    private void OnDisable()
    {
        PlayerHealth.OnDie -= DesEnemy;
    }

    private void DesEnemy()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            levelController.AddExp(5);
            DesEnemy();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerController.playerHealth.TakeDamage(5);
            DesEnemy();
        }
    }
}
