using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidIdle : EnemyState
{
    
    public override void OnStateEnter(EnemyBehaviour _behaviour)
    {
        _behaviour.ChangeState(_behaviour.attack);
    }

    public override void OnStateExit(EnemyBehaviour _behaviour)
    {
        
    }

    public override void OnStateUpdate(EnemyBehaviour _behaviour)
    {
        
    }
}
