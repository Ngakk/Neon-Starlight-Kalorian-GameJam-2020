using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterActions : MonoBehaviour
{
    public Animator anim;

    public void Attack()
    {
        anim.SetTrigger("Slash");
    }
}
