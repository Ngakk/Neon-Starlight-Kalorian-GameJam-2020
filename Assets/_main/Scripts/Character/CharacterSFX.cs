using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class CharacterSFX : MonoBehaviour
{
    new private ManagerAudio audio;
    public Hurtbox hurtbox;

    private void OnEnable()
    {
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
