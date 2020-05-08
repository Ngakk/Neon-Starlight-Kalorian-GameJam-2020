using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    public void Move(float _x, float _z)
    {
        Vector3 finalVel = new Vector3(_x, 0, _z);
        rig.velocity = finalVel;
    }
}
