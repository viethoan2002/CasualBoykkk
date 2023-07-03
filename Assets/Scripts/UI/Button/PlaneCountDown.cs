using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlaneCountDown :BaseButton
{
    [SerializeField] private Image uiFill;

    public static event Action PlaneReady;
    public float Duration;
    private bool isReady = true;

    private float remainingDuration;


    public override void OnClick()
    {
        if (isReady)
        {
           Being(Duration);
        }
        isReady = false;
    }
    

    private void Being(float duration)
    {
        remainingDuration = duration;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (remainingDuration  > -0.1f)
        {
           uiFill.fillAmount = Mathf.InverseLerp(0, Duration, remainingDuration);
           remainingDuration-=0.1f;
           yield return new WaitForSeconds(0.1f);
        }
        OnEnd();
    }

    private void OnEnd()
    {
        isReady = true;
        PlaneReady?.Invoke();
    }

}
