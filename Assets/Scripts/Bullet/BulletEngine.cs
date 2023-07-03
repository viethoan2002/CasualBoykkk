using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEngine : MonoBehaviour
{
    [SerializeField] private Transform centerPoint;
    [SerializeField] private BulletLaunch bulletLaunch;
    [SerializeField] private float rotationSpeed = 1f;
    [SerializeField] private float radius = 1f;

    [SerializeField] private float angle = 0f;  

    // Update is called once per frame
    void Update()
    {
        //if (bulletLaunch.OnActive)
        //{
        //    RotateAround();
        //}
    }

    private void RotateAround()
    {
        float x = centerPoint.position.x + Mathf.Cos(angle) * radius;
        float y = centerPoint.position.y;
        float z = centerPoint.position.z+Mathf.Sin(angle) * radius; ;

        transform.position = new Vector3(x, y, z);

        angle += rotationSpeed * Time.deltaTime;

    }
}
