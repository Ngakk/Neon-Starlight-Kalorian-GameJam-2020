using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class CharacterSFX : MonoBehaviour
{
    ManagerAudio audio;
    
    void Start()
    {
        audio = ManagerStatic.audioManager;
    }

    public void StepSound()
    {
        audio.PlaySound(DeezNuts.WALK, transform.position);
    }

    public void HurtSound()
    {

    }
}
