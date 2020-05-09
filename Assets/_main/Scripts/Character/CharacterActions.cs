using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterActions : MonoBehaviour
{
    public Animator anim;
    public SpriteRenderer spriteRenderer;
    public CharacterMovement movement;
    public Hurtbox hurtbox;

    private Camera cam;
    private bool isHurt, isDead;
    //private readonly int IsWalkingId = Animator.StringToHash

    private void OnEnable()
    {
        hurtbox.onHurt += OnHurt;
    }

    private void OnDisable()
    {
        hurtbox.onHurt -= OnHurt;
    }

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if (movement.influence > 0.9f && !isDead)
        { 
            if(isHurt)
            {
                isHurt = false;
                anim.SetTrigger("Recover");
            }
            anim.SetBool("IsWalking", movement.GetVelocity().magnitude > float.Epsilon);
            Vector3 forward = Vector3.ProjectOnPlane(cam.transform.forward, Vector3.up).normalized;
            Vector3 right = Vector3.ProjectOnPlane(cam.transform.right, Vector3.up).normalized;
            Vector3 vel = movement.GetVelocity();
            float forwardDot = Vector3.Dot(vel.normalized, forward);
            float sideDot = Vector3.Dot(vel.normalized, right);

            if(Mathf.Abs(forwardDot) > Mathf.Abs(sideDot))
            {
                if (forwardDot > 0)
                    anim.SetInteger("WalkMode", 1);
                else
                    anim.SetInteger("WalkMode", 2);
            }
            else
            {
                anim.SetInteger("WalkMode", 0);
                if(sideDot < 0)
                {
                    spriteRenderer.gameObject.transform.localScale = new Vector3(-1, 1, 1);
                }
                else
                {
                    spriteRenderer.gameObject.transform.localScale = new Vector3(1, 1, 1);
                }
            }
        }
        if(movement.influence >= 1 && isDead)
        {
            anim.SetBool("IsDead", true);
        }
    }

    public void Attack()
    {
        anim.SetBool("IsWalking", false);
        anim.SetTrigger("Slash");
    }

    void OnHurt(HitData _hitData)
    {
        anim.SetTrigger("Hurt");
        isHurt = true;
    }

    public void Die()
    {
        //anim.ResetTrigger("Hurt");
        //isHurt = false;
        //anim.SetBool("IsDead", true);
        isDead = true;
        movement.influence = 0;
    }
}
