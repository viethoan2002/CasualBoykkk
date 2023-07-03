using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] private Transform bienForward;
    [SerializeField] private Transform bienBack;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;
    Vector3 direction;
    private void Start()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (transform.position.z > bienForward.position.z)
        {
            direction = Vector3.back;
        }

        if (transform.position.z < bienBack.position.z)
        {
            direction = Vector3.forward;
        }

        rb.velocity=(direction * Time.deltaTime * speed);
    }
}
