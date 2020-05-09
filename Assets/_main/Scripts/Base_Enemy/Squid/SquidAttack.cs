using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidAttack : EnemyState
{
    public override void OnStateEnter(EnemyBehaviour _behaviour)
    {
        _behaviour.onHurt += OnHurt;
    }

    public override void OnStateExit(EnemyBehaviour _behaviour)
    {

    }

    public override void OnStateUpdate(EnemyBehaviour _behaviour)
    {
        _behaviour.onHurt -= OnHurt;
    }

    void OnHurt(HitData _hitData)
    {

    }
}
