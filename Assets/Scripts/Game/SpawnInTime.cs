using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInTime : MonoBehaviour
{
    [SerializeField] private float timedown;
    [SerializeField] private float timespawn;
    [SerializeField] private int countEnemy;
    private int currentCountEnemy;
    private bool isSpawn = true;
    public event Action InstateObject = delegate { };
    // Start is called before the first frame update
    void Start()
    {
        // timeCountDown.setTime(1);
        currentCountEnemy = countEnemy + 1;
        StartCoroutine(spawnObject());
    }

    public void PauseSpawn()
    {
        Debug.Log("pause");
        isSpawn = false;
       // StartCoroutine(spawnObject(false));
    }

    public void ResumeSpawn()
    {
        currentCountEnemy = countEnemy + 1;
        isSpawn = true;
       // StartCoroutine(spawnObject(true));
    }

    
    IEnumerator spawnObject()
    {
        while (isSpawn)
        {
            if (countEnemy > currentCountEnemy)
            {
                InstateObject();
                currentCountEnemy += 1;
                yield return new WaitForSeconds(timespawn);
            }
            else
            {
                yield return new WaitForSeconds(timedown);
                currentCountEnemy = 0;
            }
        }
    }

}
