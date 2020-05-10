using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class MasterAudioGenerator : MonoBehaviour
{
    new private ManagerAudio audio;

    void Start()
    {
        audio = ManagerStatic.audioManager;
        Invoke("MenuMusic", 0.1f);
    }

    public void UI_ClickSound()
    {
        audio.PlaySoundGlobal(DeezNuts.UI_CLICK, 1, Mixer.SFX);
    }

    public void FightMusic()
    {
        audio.PlaySoundGlobalLoop(DeezNuts.FIGHT_MUSIC, 0, Mixer.MUSIC);
    }

    public void MenuMusic()
    {
        audio.PlaySoundGlobalLoop(DeezNuts.BACKGROUNDMUSIC, 0, Mixer.MUSIC);
    }

    public void UI_SelectLevel()
    {
        audio.PlaySoundGlobal(DeezNuts.UI_CLICK, 2, Mixer.SFX);
    }
}
