using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSoundCtrl : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip clip;
    void Start()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefs.GetFloat("Volume");
    }

    public void PlaySoundPlane()
    {
        audioSource.PlayOneShot(clip);
    }
}
