using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAction : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private BulletLaunch bulletLaunch;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
          //  Destroy(gameObject);
        }
    }
}
