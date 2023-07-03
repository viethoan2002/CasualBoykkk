using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExpController : MonoBehaviour
{
    [SerializeField] private float expNeed;
    [SerializeField] private float currentExp;

    public static event Action OnAddExp;
    public static event Action CompleteMap;

    public float GetCurrentExp()
    {
        return this.currentExp/this.expNeed;
    }

    public float GetExpNeed()
    {
        return this.currentExp;
    }

    public void AddExp(int exp)
    {
        this.currentExp += exp;
        OnAddExp?.Invoke();
        CheckCompleteMap();
    }

    private void CheckCompleteMap()
    {
        if (currentExp >= expNeed)
        {
            CompleteMap?.Invoke();
        }
    }
}
