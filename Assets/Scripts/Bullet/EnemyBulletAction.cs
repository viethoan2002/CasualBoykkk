using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletAction : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(10);
            Destroy(gameObject);
        }
    }
}
