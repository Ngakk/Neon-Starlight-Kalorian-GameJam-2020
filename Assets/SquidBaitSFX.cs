using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class SquidBaitSFX : MonoBehaviour
{
    new private ManagerAudio audio;

    void Start()
    {
        audio = ManagerStatic.audioManager;
    }

    public void SplashSound()
    {
        audio.PlaySound(DeezNuts.SQUIDBAIT_SFX, 0, transform.position, Mixer.SFX);
    }

    public void MonsterGruntSound()
    {
        audio.PlaySound(DeezNuts.SQUIDBAIT_SFX, 1, transform.position, Mixer.SFX);
    }

    public void GetDamaged()
    {
        audio.PlaySound(DeezNuts.SQUIDBAIT_SFX, 2, transform.position, Mixer.SFX);
    }
}
