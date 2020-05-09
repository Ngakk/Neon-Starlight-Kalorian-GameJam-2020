using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Clamidia Idle State", menuName = "EnemyStates/Babosa/Idle")]
public class Babosa_Idle : EnemyState
{
    public override void OnStateEnter(EnemyBehaviour _behaviour)
    {
        timeStamp = Time.time;
        Debug.Log("Idle state enter");
        _behaviour.onHurt += OnHurt;
    }

    public override void OnStateExit(EnemyBehaviour _behaviour)
    {
        _behaviour.onHurt -= OnHurt;
    }

    private bool canAttack = true;
    private float timeStamp;
    private float numRand;
    private float randCooldown;

    public override void OnStateUpdate(EnemyBehaviour _behaviour)
    {
        numRand = Random.Range(0.0f, 1.0f);
        if(canAttack && numRand <= 0.1f)
        {
            timeStamp = Time.time;
            randCooldown = Random.Range(10.0f, 15.0f);
            canAttack = false;
             _behaviour.ChangeState(_behaviour.attack);
        }
        if(Time.time > timeStamp + randCooldown)
        {
            canAttack = true;
        }
    }

    void OnHurt(HitData _hitData, EnemyBehaviour _behaviour)
    {
        Debug.Log("Idle on hurt");
        _behaviour.ChangeState(_behaviour.hurt);
    }
}
