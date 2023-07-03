using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketAction : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public GameObject targetBigBullet; //{ get; set; }
    [SerializeField] private RocketApper rocketApper;

    void Update()
    {
        if (transform.position.y <= 10)
        {
            transform.position = new Vector3(targetBigBullet.transform.position.x, 10, targetBigBullet.transform.position.z);
            rocketApper.isAppear = true;
        }
    }

    private void OnEnable()
    {
        PlayerHealth.OnDie += DesRocket;
    }

    private void OnDisable()
    {
        PlayerHealth.OnDie -= DesRocket;
    }

    private void DesRocket()
    {
        Destroy(targetBigBullet);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject==targetBigBullet)
        {
            //Destroy(other.gameObject);
            //Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(50);
        }
    }
}
