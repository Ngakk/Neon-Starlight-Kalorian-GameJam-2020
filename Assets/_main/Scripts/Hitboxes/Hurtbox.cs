using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void HurtboxEvent(HitData _hitData);

[RequireComponent(typeof(Rigidbody))]
public class Hurtbox : MonoBehaviour
{
    public Transform hurtboxParent;
    private Collider[] colliders;

    public HurtboxEvent onHurt;

    private void Start()
    {
        colliders = hurtboxParent.GetComponentsInChildren<Collider>();
        foreach (var c in colliders)
        {
            c.isTrigger = false;
            c.gameObject.layer = 8;

            var part = c.GetComponent<HurtboxMessenger>();
            if (part == null)
                part = c.gameObject.AddComponent<HurtboxMessenger>();

            part.hurtbox = this;
        }
    }

    public void OnHit(HitData _hitData)
    {
        Debug.Log("Hurtbox onHit");
        onHurt?.Invoke(_hitData);
    }

}
