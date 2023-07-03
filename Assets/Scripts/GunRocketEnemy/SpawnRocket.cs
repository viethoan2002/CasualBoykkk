using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocket : MonoBehaviour
{
    //[SerializeField] private Rigidbody rb;
    [SerializeField] private Transform originPosition;
    [SerializeField] private Transform targetPosition;
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private SpawnInTime spawn;
    [SerializeField] private GameObject prefBullet;
    [SerializeField] private float time;
    [SerializeField] private GameObject prefCircle;

    private Vector3 Vo;

    private void Start()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        targetPosition = GameObject.Find("PlayerCharacter").transform;
    }

    private void Awake()
    {
        spawn.InstateObject += Fire;
    }

    private void Fire()
    {
        InstateCircle();
    }

    private void InstateCircle()
    {
        Vector3 positionSpawn = new Vector3(targetPosition.position.x, 10.01f, targetPosition.position.z);
        GameObject circle= Instantiate(prefCircle, positionSpawn, prefCircle.transform.rotation);
        InstateBullet(circle);
    }

    private void InstateBullet(GameObject circle)
    {
        GameObject gameObject1 = Instantiate(prefBullet,spawnPosition.position, prefBullet.transform.rotation);
        gameObject1.GetComponent<RocketAction>().targetBigBullet=circle;
        Rigidbody obj = gameObject1.GetComponent<Rigidbody>();
        obj.velocity = Vo;
    }

    // Start is called before the first frame update
    void Update()
    {
        RotateGunRocket();
    }

    private void RotateGunRocket()
    {
        if (targetPosition != null)
        {
        Vo = CalculateVelocity(originPosition.position, targetPosition.position, time);
        transform.rotation = Quaternion.LookRotation(Vo);
        }
    }

    Vector3 CalculateVelocity(Vector3 origin,Vector3 target,float time)
    {
        Vector3 distance = target - origin;
        Vector3 distanceXZ = distance;
        distanceXZ.y = 0;

        float Sy = distance.y;
        float Sxz = distanceXZ.magnitude;

        float Vxz = Sxz / time;
        float Vy = Sy / time + 0.5f * Mathf.Abs(Physics.gravity.y) * time;

        Vector3 result = distanceXZ.normalized;
        result *= Vxz;
        result.y = Vy;

        return result;

    }
}
