﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioDrop : MonoBehaviour
{
    public AudioSource audioSource;
    
    void OnSpawn()
    {

    }

    public void Play()
    {
        Invoke("SelfDespawn", audioSource.clip.length + 0.1f);
        audioSource.Play();
    }

    public void SelfDespawn()
    {
        PoolManager.Despawn(gameObject);
    }

    void OnDespawn()
    {
        audioSource.Stop();
    }
}
