using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Clamidia Die State", menuName = "EnemyStates/Babosa/Die")]
public class Babaosa_Die : EnemyState
{
    public override void OnStateEnter(EnemyBehaviour _behaviour)
    {
        _behaviour.animator.SetTrigger("IsDead");
        _behaviour.onDieUEvent?.Invoke();
    }

    public override void OnStateExit(EnemyBehaviour _behaviour)
    {

    }

    public override void OnStateUpdate(EnemyBehaviour _behaviour)
    {
        
    }
}
