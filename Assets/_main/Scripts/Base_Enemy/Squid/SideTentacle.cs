using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SideTentacle : MonoBehaviour
{
    public GameObject target;
    public Animator anim;
    public Health squidHealth;
    public float velocity;
    public float startingDelay = 0f;

    private void Start()
    {
        Attack(GetAttackTime() + startingDelay);
    }

    public void Attack(float _delay)
    {
        //StartCoroutine(FollowToAttack(_delay));

        Sequence seq = DOTween.Sequence();
        float dummy = 0;
        seq.Append(DOTween.To(() => { return dummy; }, (x) =>
        {
            dummy = x;

            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Lerp(transform.position.z, target.transform.position.z, 0.01f));

        }, 1f, _delay));
        seq.AppendCallback(AttackAnim);
        seq.SetDelay(1.5f);
        seq.AppendCallback(() => { Attack(GetAttackTime()); });

    }

    void AttackAnim()
    {
        anim.SetTrigger("Attack");
    }

    float GetAttackTime()
    {
        float difficulty = Mathf.InverseLerp(squidHealth.maxHealth, 20, squidHealth.currentHealth);

        return Mathf.Lerp(2f, 10f, 1-difficulty);
    }
}
