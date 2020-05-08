using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    [Header("Setup")]
    public Transform direction;
    [Header("Settings")]
    public HitData hitData;

    private Collider[] colliders;
    private List<Collider> hurtboxes = new List<Collider>();

    private void Start()
    {
        colliders = GetComponentsInChildren<Collider>();
        foreach (var c in colliders)
        {
            c.isTrigger = true;
            c.gameObject.layer = 8;
        }
    }

    private void OnDisable()
    {
        hurtboxes = new List<Collider>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (!hurtboxes.Contains(other))
        {
            hitData.direction = direction.forward;
            hitData.sourcePosition = transform.position;
            other.SendMessage("OnHit", hitData, SendMessageOptions.DontRequireReceiver);
            hurtboxes.Add(other);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (!hurtboxes.Contains(other))
        {
            hitData.direction = direction.forward;
            hitData.sourcePosition = transform.position;
            other.SendMessage("OnHit", hitData, SendMessageOptions.DontRequireReceiver);
        }
    }

    private void OnDrawGizmos()
    {
        if(direction)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, transform.position + direction.forward);
            Gizmos.DrawWireSphere(transform.position + direction.forward, 0.1f);
            Gizmos.color = Color.white;
        }
    }

}

[System.Serializable]
public class HitData
{
    public float damage;
    public float knockback;
    public float knockbackTime;
    [HideInInspector] public Vector3 sourcePosition;
    [HideInInspector] public Vector3 direction;
}
