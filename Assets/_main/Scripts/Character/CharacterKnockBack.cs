using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CharacterKnockBack : MonoBehaviour
{
    [SerializeField] private CharacterMovement movement = null;
    [SerializeField] private Hurtbox hurtbox = null;

    private void OnEnable()
    {
        hurtbox.onHurt += OnHurt;
    }

    private void OnDisable()
    {
        hurtbox.onHurt -= OnHurt;
    }

    void OnHurt(HitData _hitData)
    {
        movement.RemoveInfluence();
        movement.RestoreInfluence(_hitData.knockbackTime);
        
        movement.AddVelocity(_hitData.direction * _hitData.knockback);
    }
}
