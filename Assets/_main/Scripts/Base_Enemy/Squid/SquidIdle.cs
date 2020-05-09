using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Idle State", menuName = "EnemyStates/Idle")]
public class SquidIdle : EnemyState
{
    public override void OnStateEnter(EnemyBehaviour _behaviour)
    {
        Debug.Log("Idle state enter");
        _behaviour.onHurt += OnHurt;
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
        Debug.Log("Idle on hurt");
        _behaviour.ChangeState(_behaviour.hurt);
    }
}
