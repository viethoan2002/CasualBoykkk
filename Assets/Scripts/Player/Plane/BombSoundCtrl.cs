using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSoundCtrl : MonoBehaviour
{
    [SerializeField] private AudioSource audio;
    [SerializeField] private AudioClip clip;
    void Start()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        audio = GetComponent<AudioSource>();
    }

    public void PlayBombSound()
    {
        audio.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
