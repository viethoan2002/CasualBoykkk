using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySoundCtrl : MonoBehaviour
{
    [SerializeField] private AudioSource audio;
    [SerializeField] private AudioClip clipDead;
    [SerializeField] private AudioClip cliptkdamage;

    private void Start()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        audio = GetComponent<AudioSource>();
    }

    public void PlaySoundDead()
    {
        audio.PlayOneShot(clipDead);
    }

    public void PlaySoundDamage()
    {
        audio.PlayOneShot(cliptkdamage);
    }
}
