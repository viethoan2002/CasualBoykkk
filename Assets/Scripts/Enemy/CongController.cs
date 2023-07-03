using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongController : MonoBehaviour
{
    [SerializeField] private SpawnInTime spawn;
    [SerializeField] private Transform positionInstate;
    [SerializeField] private GameObject prefObject;

    private void Awake()
    {
        spawn.InstateObject += InstateEnemy;
    }

    public void InstateEnemy()
    {
        Instantiate(prefObject, positionInstate.position, prefObject.transform.rotation);
    }
}
