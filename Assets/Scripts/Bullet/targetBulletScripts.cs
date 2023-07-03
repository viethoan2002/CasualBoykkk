using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetBulletScripts : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private SpawnInTime spawn;
    [SerializeField] private float timeTarget;
    // Start is called before the first frame update
    private void Awake()
    {
        spawn.InstateObject += updatePosition;
    }

    private void updatePosition()
    {
        Vector3 velocityPlayer = Player.GetComponent<Rigidbody>().velocity;
        transform.position = velocityPlayer * timeTarget + Player.transform.position;
    }

}
