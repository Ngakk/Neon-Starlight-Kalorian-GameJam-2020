using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class SpitSFX : MonoBehaviour
{
    void Start()
    {
        
    }

    public void SplashSound()
    {
        ManagerStatic.audioManager.PlaySound(DeezNuts.CLAMIDIA_SFX, 0, transform.position, Mixer.SFX);
    }
}
