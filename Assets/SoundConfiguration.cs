using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundConfiguration : MonoBehaviour
{
    public AudioMixer masterVolume;

    void Start()
    {
        
    }

    public void SetMasterVolume(float _val)
    {
        masterVolume.SetFloat("masterVolume", _val);
    }

    public void SetMusicVolume(float _val)
    {
        masterVolume.SetFloat("musicVolume", _val);
    }

    public void SetSFXVolume(float _val)
    {
        masterVolume.SetFloat("sfxVolume", _val);
    }
}
