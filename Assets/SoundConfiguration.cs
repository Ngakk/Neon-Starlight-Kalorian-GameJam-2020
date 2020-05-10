using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundConfiguration : MonoBehaviour
{
    public Slider masterVolumeSlider;
    public Slider sfxVolumeSlider;
    public Slider musicVolumeSlider;

    public AudioMixer masterVolume;

    void Start()
    {
        
    }

    public void SetMasterVolume(float _level)
    {
        masterVolume.SetFloat("masterVolume", _level);
    }

    public void SetMusicVolume(float _level)
    {
        masterVolume.SetFloat("musicVolume", _level);
    }

    public void SetSFXVolume(float _level)
    {
        masterVolume.SetFloat("sfxVolume", _level);
    }
}
