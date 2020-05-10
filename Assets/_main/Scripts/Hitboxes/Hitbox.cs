using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    [Header("Settings")]
    public HitData hitData;
    public bool isAlly;

    private Collider[] colliders;
    private List<Collider> hurtboxes = new List<Collider>();

    private void Start()
    {
        colliders = GetComponentsInChildren<Collider>();

        foreach (var c in colliders)
        {
            c.isTrigger = true;
            if (isAlly)
                c.gameObject.layer = 8;
            else
                c.gameObject.layer = 10;
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
            hitData.sourcePosition = transform.position;
            hitData.direction = hitData.rotation * Vector3.ProjectOnPlane(transform.forward, Vector3.up).normalized;
            other.SendMessage("OnHit", hitData, SendMessageOptions.DontRequireReceiver);
            hurtboxes.Add(other);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (!hurtboxes.Contains(other))
        {
            hitData.sourcePosition = transform.position;
            hitData.direction = hitData.rotation * Vector3.ProjectOnPlane(transform.forward, Vector3.up).normalized;
            other.SendMessage("OnHit", hitData, SendMessageOptions.DontRequireReceiver);
        }
    }

    private void OnDrawGizmos()
    {

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + hitData.direction.normalized * 2f);
        hitData.direction = hitData.rotation * Vector3.ProjectOnPlane(transform.forward, Vector3.up).normalized;
        Gizmos.DrawWireSphere(transform.position + hitData.direction.normalized * 2f, 0.1f);
        Gizmos.color = Color.white;

    }

}

[System.Serializable]
public class HitData
{
    public float damage;
    public float knockback;
    public float knockbackTime;
    [HideInInspector] public Vector3 sourcePosition;
    [HideInInspector] public Quaternion rotation;
    [HideInInspector] public Vector3 direction;
}
