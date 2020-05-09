using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Hurt State", menuName = "EnemyStates/Hurt")]
public class SquidHurt : EnemyState
{
    public float hurtTime = 1f;

    private float lastHurtTime;

    public override void OnStateEnter(EnemyBehaviour _behaviour)
    {
        Debug.Log("Hurt enter state");
        if(_behaviour.ownHealth.currentHealth <= 0)
        {
            _behaviour.ChangeState(_behaviour.die);
        }
        else
        {
            Debug.Log("Calling squid animator");
            _behaviour.animator.SetTrigger("Take_Damage");
            _behaviour.onHurtUEvent?.Invoke();
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
