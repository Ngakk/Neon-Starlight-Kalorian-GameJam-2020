using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidDie : EnemyState
{
    public override void OnStateEnter(EnemyBehaviour _behaviour)
    {
        _behaviour.animator.SetTrigger("IsDead");
    }

    public override void OnStateExit(EnemyBehaviour _behaviour)
    {
    }

    public override void OnStateUpdate(EnemyBehaviour _behaviour)
    {
    }
}
