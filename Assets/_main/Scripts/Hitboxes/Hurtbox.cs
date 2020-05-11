using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void HurtboxEvent(HitData _hitData);

[RequireComponent(typeof(Rigidbody))]
public class Hurtbox : MonoBehaviour
{
    public Transform hurtboxParent;
    public bool isAlly;
    public float invulnerableTime = 1f;
    public bool isInvulnerable;

    private Collider[] colliders;
    private float lastHitTime;

    public HurtboxEvent onHurt;

    private void Start()
    {
        colliders = hurtboxParent.GetComponentsInChildren<Collider>();
        lastHitTime = -1;
        foreach (var c in colliders)
        {
            c.isTrigger = false;
            if (isAlly)
                c.gameObject.layer = 10;
            else
                c.gameObject.layer = 8;

            var part = c.GetComponent<HurtboxMessenger>();
            if (part == null)
                part = c.gameObject.AddComponent<HurtboxMessenger>();

            part.hurtbox = this;
        }
    }

    public void OnHit(HitData _hitData)
    {
        if (Time.time > lastHitTime + invulnerableTime)
        {
            lastHitTime = Time.time;
            onHurt?.Invoke(_hitData);
        }
    }
}
