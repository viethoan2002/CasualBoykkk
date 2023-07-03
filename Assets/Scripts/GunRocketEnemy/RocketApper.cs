using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketApper : MonoBehaviour
{
    [SerializeField] private float speedscale;
    private float currentScale;
    [SerializeField] private float maxScale;
    [SerializeField] private float startScale;
    [SerializeField] private RocketAction rocketAction;
    public bool isAppear = false;

    void Start()
    {
        this.currentScale = this.startScale;
    }

    private void FixedUpdate()
    {
        if(isAppear) Appearing();
    }
    private void Appearing()
    {
        this.currentScale += this.speedscale;
        transform.localScale = new Vector3(this.currentScale, this.currentScale, this.currentScale);
        if (this.currentScale >= maxScale) Appear();
    }

    private void Appear()
    {
        Destroy(rocketAction.targetBigBullet);
        Destroy(gameObject);
    }
}
