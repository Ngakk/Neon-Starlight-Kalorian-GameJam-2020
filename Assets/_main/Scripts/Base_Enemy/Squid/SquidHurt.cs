using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidHurt : EnemyState
{
    public float hurtTime = 1f;

    private float lastHurtTime;

    public override void OnStateEnter(EnemyBehaviour _behaviour)
    {
        if(_behaviour.ownHealth.currentHealth <= 0)
        {
            _behaviour.ChangeState(_behaviour.die);
        }
        else
        {
            _behaviour.animator.SetTrigger("Take_Damage");
        }
        lastHurtTime = Time.time;
    }

    public override void OnStateExit(EnemyBehaviour _behaviour)
    {

    }

    public override void OnStateUpdate(EnemyBehaviour _behaviour)
    {
        if(Time.time > lastHurtTime + hurtTime)
        {
            _behaviour.ChangeState(_behaviour.idle);
        }
    }
}
