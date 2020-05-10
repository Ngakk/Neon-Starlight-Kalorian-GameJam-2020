﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class MasterAudioGenerator : MonoBehaviour
{
    new private ManagerAudio audio;

    void Start()
    {
        audio = ManagerStatic.audioManager;
        audio.PlaySoundGlobal(DeezNuts.FIGHT_MUSIC, 0);
    }

    public void UI_ClickSound()
    {
        audio.PlaySoundGlobal(DeezNuts.UI_CLICK);
    }
}
