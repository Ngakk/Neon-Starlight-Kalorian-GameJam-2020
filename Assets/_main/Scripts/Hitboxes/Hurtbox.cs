using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void HurtboxEvent(HitData _hitData);

[RequireComponent(typeof(Rigidbody))]
public class Hurtbox : MonoBehaviour
{
    private Collider[] colliders;

    public HurtboxEvent onHurt;

    private void Start()
    {
        colliders = GetComponentsInChildren<Collider>();
        foreach (var c in colliders)
        {
            c.isTrigger = false;
            c.gameObject.layer = 8;
        }
    }

    public void OnHit(HitData _hitData)
    {
        onHurt?.Invoke(_hitData);
    }

}
