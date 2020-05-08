using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void HurtboxEvent(HitData _hitData);

[RequireComponent(typeof(Rigidbody))]
public class Hurtbox : MonoBehaviour
{
    [SerializeField] private Rigidbody rigi;
    [SerializeField] private Collider[] colliders;

    public HurtboxEvent onHit;

    private void Start()
    {
        foreach(var c in colliders)
        {
            c.isTrigger = false;
        }

        if (!rigi) rigi = GetComponent<Rigidbody>();

        rigi.isKinematic = true;
    }

    public void OnHit(HitData _hitData)
    {
        onHit?.Invoke(_hitData);
    }

}
