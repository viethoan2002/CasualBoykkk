using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPlayerManager : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private GameObject bullet;
    [SerializeField] private List<GameObject> listBullet;
    public int numberOfPoints = 0; // Số lượng điểm cần đặt
    public float radius = 5f; // Bán kính của cung tròn

    private void Start()
    {
    }
    public void AddBullet()
    {
        GameObject bullet = Instantiate(this.bullet);
        numberOfPoints += 1;
        listBullet.Add(bullet);
        SetUpBulletPosition();
    }
 
    private void SetUpBulletPosition()
    {   
        float angleStep = 360f / numberOfPoints;
        for (int i = 0; i < numberOfPoints; i++)
        {   
            float angle = i * angleStep;
            float x = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
            float y = 0f;
            float z = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;

            listBullet[i].transform.position = new Vector3(x+Player.position.x, y + Player.position.y, z + Player.position.z);
            listBullet[i].transform.SetParent(transform); 
        }
    }
}
