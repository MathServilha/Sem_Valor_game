﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeChanger : MonoBehaviour
{
    private AudioSource AudioSrc;

    private float AudioVolume = 0.25f;

    void Start()
    {
        AudioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        AudioSrc.volume = AudioVolume;
    }

    public void SetVolume(float vol)
    {
        AudioVolume = vol;
    }
}