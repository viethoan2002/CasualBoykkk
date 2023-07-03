using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlaneEngine : MonoBehaviour
{
    [SerializeField] private SpawnInTime spawn;
    [SerializeField] private GameObject prefBomb;
    [SerializeField] private PlaneCtrl planeCtrl;
    [SerializeField] private GameObject prefCircle;
    [SerializeField] private Transform raycastPoint;
    [SerializeField] private PlaneSoundCtrl soundCtrl;

    private Vector3 startPosition;
    private float speed=0;

    void Start()
    {
        LoadComponent();
    }

    private void OnEnable()
    {
        PlaneAbilityCtrl.OnBomb += StartSpawnBomb;
        PlaneAbilityCtrl.OffBomb += RestartSpawnBomb;
    }

    private void OnDisable()
    {
        PlaneAbilityCtrl.OnBomb -= StartSpawnBomb;
        PlaneAbilityCtrl.OffBomb -= RestartSpawnBomb;
    }

    private void RestartSpawnBomb()
    {
        speed = 0;
        transform.position = startPosition;
    }

    private void StartSpawnBomb()
    {
        speed = 15;
        soundCtrl.PlaySoundPlane();
    }

    private void LoadComponent()
    {
        startPosition = transform.position;
        planeCtrl = GetComponent<PlaneCtrl>();
        soundCtrl = GetComponent<PlaneSoundCtrl>();
        spawn =planeCtrl.spawnInTime;
    }

    private void Awake()
    {
        spawn.InstateObject += SpawnBomb;
    }

    private void SpawnBomb()
    {
        InstateCircle();
    }

    private void InstateCircle()
    {      
        Physics.Raycast(raycastPoint.position, Vector3.down, out RaycastHit hit);
        if (hit.transform != null)
        {
            GameObject circle = Instantiate(prefCircle,  new Vector3(transform.position.x, 10.01f, transform.position.z), prefCircle.transform.rotation);
            InstateBullet(circle);
        }
    }

    private void InstateBullet(GameObject circle)
    {
        GameObject gameObject1 = Instantiate(prefBomb, transform.position, prefBomb.transform.rotation);
        gameObject1.GetComponent<BombAction>().targetBigBullet = circle;
        Rigidbody obj = gameObject1.GetComponent<Rigidbody>();
        obj.velocity = Vector3.forward*Time.deltaTime*30;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void DebugRayCast(Vector3 start,RaycastHit hit,Vector3 direction)
    {
        if (hit.transform == null)
        {
            Debug.DrawLine(start, direction, Color.red);
        }
        else
        {
            Debug.DrawLine(start, direction, Color.green);
        }
    }
}
