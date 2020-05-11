using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontTentacles : MonoBehaviour
{
    public Animator anim;
    public void Attack(float _delay)
    {
        Invoke("AttackAnim", _delay);
    }

    void AttackAnim()
    {
        anim.SetTrigger("Attack");
    }
}
