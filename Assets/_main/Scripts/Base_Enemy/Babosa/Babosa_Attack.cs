using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Clamidia Attack State", menuName = "EnemyStates/Babosa/Attack")]
public class Babosa_Attack : EnemyState
{
    public GameObject rain;

    private float timeCC;
    public override void OnStateEnter(EnemyBehaviour _behaviour)
    {
        Debug.Log("Attack state enter");
        _behaviour.onHurt += OnHurt;
        _behaviour.animator.SetTrigger("MakeDamage");
        timeCC = Time.time;
    }

    public override void OnStateExit(EnemyBehaviour _behaviour)
    {
        _behaviour.onHurt -= OnHurt;
    }

    public override void OnStateUpdate(EnemyBehaviour _behaviour)
    {
        if(Time.time > timeCC + 2.0f)
        {
            _behaviour.ChangeState(_behaviour.idle);
        }
    }

    void OnHurt(HitData _hitData, EnemyBehaviour _behaviour)
    {
        Debug.Log("Attack on hurt");
        _behaviour.ChangeState(_behaviour.hurt);
    }
}
