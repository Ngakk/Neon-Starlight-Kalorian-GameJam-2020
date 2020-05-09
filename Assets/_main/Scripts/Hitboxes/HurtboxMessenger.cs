using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtboxMessenger : MonoBehaviour
{
    [HideInInspector] public Hurtbox hurtbox;
    void OnHit(HitData _hitData)
    {
        hurtbox.OnHit(_hitData);
    }
}
