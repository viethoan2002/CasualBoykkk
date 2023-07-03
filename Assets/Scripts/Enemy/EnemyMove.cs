using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : CharacterController,EnemyInterface
{
    private Transform TargetPosition;

    [SerializeField] private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        TargetPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
    }

    public virtual void MoveToPlayer()
    {
        agent.SetDestination(TargetPosition.position);
    }

    public virtual void EnemySkill()
    {

    }
}
