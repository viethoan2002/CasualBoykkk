using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAbilityCtrl : MonoBehaviour
{
    public static event Action OnBomb;
    public static event Action OffBomb;

    public void StartBomb()
    {
        OnBomb?.Invoke();
        StartCoroutine(TimeToSpawnBomb());
    }

    IEnumerator TimeToSpawnBomb()
    {
        yield return new WaitForSeconds(10);
        OffBomb?.Invoke();
    }
}
