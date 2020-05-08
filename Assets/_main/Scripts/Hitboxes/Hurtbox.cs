using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void HurtboxEvent(HitData _hitData);

[RequireComponent(typeof(Rigidbody))]
public class Hurtbox : MonoBehaviour
{
    [SerializeField] private Rigidbody rigi;
    private Collider[] colliders;

    public HurtboxEvent onHit;

    private void Start()
    {
        colliders = GetComponentsInChildren<Collider>();
        foreach (var c in colliders)
        {
            c.isTrigger = false;
            c.gameObject.layer = 8;
        }

        if (!rigi) rigi = GetComponent<Rigidbody>();

        rigi.isKinematic = true;
    }

    public void OnHit(HitData _hitData)
    {
        onHit?.Invoke(_hitData);
    }

}
