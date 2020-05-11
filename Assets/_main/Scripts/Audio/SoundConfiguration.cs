using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundConfiguration : MonoBehaviour
{
    public Slider masterSlider;
    public Slider musicSlider;
    public Slider sfxSlider;

    public AudioMixer masterVolume;

    void Start()
    {
        
    }

    public void SetMasterVolume()
    {
        masterVolume.SetFloat("masterVolume", masterSlider.value);
    }

    public void SetMusicVolume()
    {
        masterVolume.SetFloat("musicVolume", musicSlider.value);
    }

    public void SetSFXVolume()
    {
        masterVolume.SetFloat("sfxVolume", sfxSlider.value);
    }
}
