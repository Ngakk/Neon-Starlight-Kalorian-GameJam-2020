using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
[RequireComponent(typeof(CharacterActions))]

public class CharacterController : MonoBehaviour
{
    public float movSpeed;

    private string movHor = "Horizontal";
    private string movVer = "Vertical";
    private string atkBtn = "Attack";

    private float xSpeed;
    private float zSpeed;

    private bool isAttacking = false;

    private CharacterMovement charMov;
    private CharacterActions charAct;

    void Start()
    {
        charMov = GetComponent<CharacterMovement>();
        charAct = GetComponent<CharacterActions>();
    }

    void Update()
    {
        GetInputs();
        ProcessInputs();        
    }

    private void GetInputs()
    {
        xSpeed = Input.GetAxis(movHor) * movSpeed;
        zSpeed = Input.GetAxis(movVer) * movSpeed;

        isAttacking = Input.GetButtonDown(atkBtn);
    }

    private void ProcessInputs()
    {
        charMov.Move(xSpeed, zSpeed);

        if (isAttacking)
            charAct.Attack();
    }
}
