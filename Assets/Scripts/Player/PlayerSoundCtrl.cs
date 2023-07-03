using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundCtrl : MonoBehaviour
{
    [SerializeField] private AudioSource audio;
    [SerializeField] private AudioClip clipDamage;
    [SerializeField] private AudioClip clipExp;

    void Start()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        audio = GetComponent<AudioSource>();
        var volume = PlayerPrefs.GetFloat("Volume");
        audio.volume = volume;
    }

    private void OnEnable()
    {
        PlayerHealth.OnTakeDamage += PlaySoundTakeDamage;
        LevelController.OnAddExp += PlayeSoundExp;
    }


    private void OnDisable()
    {
        PlayerHealth.OnTakeDamage -= PlaySoundTakeDamage;
        LevelController.OnAddExp -= PlayeSoundExp;
    }

    private void PlayeSoundExp()
    {
        audio.PlayOneShot(clipExp);
    }
    private void PlaySoundTakeDamage()
    {
        audio.PlayOneShot(clipDamage);
    }
}
