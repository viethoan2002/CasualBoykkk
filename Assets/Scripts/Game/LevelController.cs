using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private float expNeed;
    [SerializeField] private float currentExp;
    [SerializeField] private List<float> listCheckPoint;

    public static event Action OnAddExp;

    public static event Action OnWin;

    public static event Action OnLevelUp;
    //public static event Action CompleteMap;


    public float GetCurrentExp()
    {
        return this.currentExp / this.expNeed;
    }

    public float GetExpNeed()
    {
        return this.currentExp;
    }

    public void AddExp(int exp)
    {
        this.currentExp += exp;
        OnAddExp?.Invoke();
        CheckPlayerLevelUp();
        CheckCompleteMap();
    }

    private void CheckPlayerLevelUp()
    {
        foreach(var i in listCheckPoint)
        {
            if (Mathf.Abs(i- this.currentExp / this.expNeed) <0.0001 && i>0)
            {
                OnLevelUp?.Invoke();
                listCheckPoint.Remove(i);
                break;
            }
        }
        
    }

    private void CheckCompleteMap()
    {
        if (currentExp >= expNeed)
        {
            MapManager.instance.UnlockNextScene();
            OnWin?.Invoke();
        }
    }


    public List<float> GetListCheckPoint()
    {
        return listCheckPoint;
    }
}
