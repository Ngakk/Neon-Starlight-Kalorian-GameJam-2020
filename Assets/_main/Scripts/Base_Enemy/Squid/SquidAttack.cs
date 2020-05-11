using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Squid Attack State", menuName = "EnemyStates/Attack")]
public class SquidAttack : EnemyState
{
    public override void OnStateEnter(EnemyBehaviour _behaviour)
    {
        _behaviour.onHurt += OnHurt;
        _behaviour.animator.SetTrigger("Attack");
    }

    public override void OnStateExit(EnemyBehaviour _behaviour)
    {
        _behaviour.onHurt -= OnHurt;
    }

    public override void OnStateUpdate(EnemyBehaviour _behaviour)
    {
        
    }

    void OnHurt(HitData _hitData, EnemyBehaviour _behaviour)
    {
        _behaviour.ChangeState(_behaviour.hurt);
    }
}
