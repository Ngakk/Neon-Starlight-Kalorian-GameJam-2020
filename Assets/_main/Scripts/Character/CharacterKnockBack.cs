using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CharacterKnockBack : MonoBehaviour
{
    [SerializeField] private CharacterMovement movement;
    [SerializeField] private Hurtbox hurtbox;

    private void OnEnable()
    {
        hurtbox.onHit += OnHurt;
    }

    private void OnDisable()
    {
        hurtbox.onHit -= OnHurt;
    }


    void OnHurt(HitData _hitData)
    {
        movement.RemoveInfluence();
        movement.RestoreInfluence(_hitData.knockbackTime);
        
        movement.AddVelocity(_hitData.direction * _hitData.knockback);
    }
}
