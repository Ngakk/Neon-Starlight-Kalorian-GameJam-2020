using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class CharacterSFX : MonoBehaviour
{
    new private ManagerAudio audio;
    public AudioDrop jukebox;
    public Hurtbox hurtbox;

    private void OnEnable()
    {
        PoolManager.MakePool(jukebox.gameObject, 50, 20, true);
        hurtbox.onHurt += OnHurt;
    }

    private void OnDisable()
    {
        hurtbox.onHurt -= OnHurt;
    }

    void Start()
    {
        audio = ManagerStatic.audioManager;
        InvokeRepeating("BreathSound", 1, 4);
        audio.PlaySoundGlobalLoop(DeezNuts.FIGHT_MUSIC, 0, Mixer.MUSIC);
    }

    public void StepSound()
    {
        audio.PlaySound(DeezNuts.WALK, transform.position, Mixer.SFX);
    }

    public void HurtSound()
    {
        audio.PlaySound(DeezNuts.CHARACTERHURT_SFX, transform.position, Mixer.SFX);
    }

    public void AttackSound()
    {
        audio.PlaySound(DeezNuts.CHARACTER_SFX, 1, transform.position, Mixer.SFX);
    }

    public void DieSound()
    {
        audio.PlaySound(DeezNuts.CHARACTER_SFX, 0, transform.position, Mixer.SFX);
    }

    public void BreathSound()
    {
        audio.PlaySound(DeezNuts.CHARACTER_SFX, 3, transform.position, Mixer.SFX);
    }

    public void OnHurt(HitData _hitData)
    {
        audio.PlaySound(DeezNuts.CHARACTERHURT_SFX, transform.position, Mixer.SFX);
    }
}
