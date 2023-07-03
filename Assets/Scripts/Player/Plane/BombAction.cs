using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAction : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public GameObject targetBigBullet; //{ get; set; }
    [SerializeField] private BombApper bombApper;
    [SerializeField] private BombSoundCtrl soundCtrl;

    void Update()
    {
        if (transform.position.y <= 10)
        {
            transform.position = new Vector3(targetBigBullet.transform.position.x, 10, targetBigBullet.transform.position.z);
            bombApper.isAppear = true;
            soundCtrl.PlayBombSound();
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
        if (other.gameObject == targetBigBullet)
        {
            //Destroy(other.gameObject);
            //Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}
