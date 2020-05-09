using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody))]

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody rig;
    private Vector3 externalVelocity;
    public float influence = 1f;

    private Vector3 finalVel;
    private bool isDead;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    public void Move(float _x, float _z)
    {
        finalVel = new Vector3(_x, 0, _z);

        if (isDead) finalVel = Vector3.zero;

        float clampedInfluence = Mathf.Clamp(influence, 0, 1);
        rig.velocity = finalVel * clampedInfluence + externalVelocity * (1 - clampedInfluence);
        if (clampedInfluence >= 1)
            externalVelocity = Vector3.zero;
    }

    public void AddVelocity(Vector3 _vel)
    {
        externalVelocity += _vel;
    }

    public void RemoveInfluence()
    {
        influence = 0;
    }

    public void RestoreInfluence(float _time)
    {
        DOTween.To(() => { return influence; }, (x) => { influence = x; }, 1f, _time).SetEase(Ease.OutQuad);
    }

    public Vector3 GetVelocity()
    {
        return finalVel;
    }

    public void Die()
    {
        isDead = true;
    }
}

