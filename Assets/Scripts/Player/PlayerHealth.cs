using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth=100;
    [SerializeField] private float health;

    public static event Action OnDie ;
    public static event Action OnRevival;
    public static event Action OnTakeDamage;
    // Start is called before the first frame update
    private void Awake()
    {
        health = maxHealth;
    }

    private void OnEnable()
    {
        LevelPlayerAds.OnReward += Revival;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
        ChangeCurrentHP();
    }

    private void Die()
    {
        OnDie?.Invoke();
    }

    public void Revival()
    {
        this.health = 50;
        OnRevival?.Invoke();
    }

    public void HealSelf(int health)
    {
        this.health += health;
        if (this.health > maxHealth)
        {
            this.health = this.maxHealth;
        }
        ChangeCurrentHP();
    }

    public float GetCurrentHealth()
    {   
        return this.health ;
    }

    public float GetMaxHealth()
    {
        return this.maxHealth;
    }

    private void ChangeCurrentHP()
    {
        OnTakeDamage?.Invoke();
    }
}
