using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class ClamidiaSFX : MonoBehaviour
{
    new ManagerAudio audio;

    void Start()
    {
        audio = ManagerStatic.audioManager;
    }

    public void GruntSound()
    {
        audio.PlaySound(DeezNuts.CLAMIDIA_SFX, 1, transform.position);
    }

    public void DieSound()
    {
        audio.PlaySound(DeezNuts.CLAMIDIA_SFX, 2, transform.position);
    }
}
