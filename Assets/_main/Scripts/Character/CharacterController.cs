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

    private Dictionary<int, int> dirFromHash = new Dictionary<int, int>()
    {
        [20] = 0, [21] = 0, [19] = 0,
        [10] = 1, [11] = 1, [12] = 1,
        [2] = 2, [1] = 2,
        [-10] = 3, [-9] = 3, [-8] = 3,
        [-21] = 4, [-20] = 4, [-19] = 4,
        [-10] = 5, [-11] = 5, [-12] = 5,
        [-2] = 6, [-1] = 6,
        [10] = 7, [9] = 7, [8] = 7,
    };

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
        {
            charAct.Attack();
        }
    }
}
