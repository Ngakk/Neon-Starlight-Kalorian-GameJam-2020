using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioDrop))]
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

    void SelfDespawn()
    {
        PoolManager.Despawn(gameObject);
    }

    void OnDespawn()
    {
        audioSource.Stop();
    }
}
