using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    [Header("Setup")]
    public Collider[] colliders;
    public Transform direction;
    [Header("Settings")]
    public HitData hitData;

    private List<Collider> hurtboxes = new List<Collider>();

    private void Start()
    {
        foreach (var c in colliders)
        {
            c.isTrigger = true;
        }
    }

    private void OnDisable()
    {
        hurtboxes = new List<Collider>();
    }


    private void OnTriggerEnter(Collider other)
    {
        hitData.direction = direction.forward;
        hitData.sourcePosition = transform.position;
        other.SendMessage("OnHit", hitData, SendMessageOptions.DontRequireReceiver);
        hurtboxes.Add(other);
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

    private void OnDrawGizmosSelected()
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
    [HideInInspector] public Vector3 sourcePosition;
    [HideInInspector] public Vector3 direction;
}
