using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRocketBodyRotate : MonoBehaviour
{
    [SerializeField] private Transform barrelTrans;

    // Update is called once per frame
    void Update()
    {
        float rotatoinY = barrelTrans.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0f, rotatoinY, 0f);
    }
}
