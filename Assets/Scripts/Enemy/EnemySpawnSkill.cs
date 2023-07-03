using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnSkill : MonoBehaviour,EnemyInterface
{
    [SerializeField] private SpawnInTime spawnInTime;

    private void Awake()
    {
        spawnInTime.InstateObject += EnemySkill;
    }

    public virtual void EnemySkill()
    {

    }

    public virtual void MoveToPlayer()
    {

    }
}
