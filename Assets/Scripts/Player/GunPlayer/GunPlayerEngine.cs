using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPlayerEngine : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private float speedRotate;
    void Update()
    {
        transform.position = Player.position;
        transform.Rotate(Vector3.up, speedRotate * Time.deltaTime);
    }
}
 