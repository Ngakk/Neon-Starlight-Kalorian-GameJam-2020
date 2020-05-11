using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Clamidia Idle State", menuName = "EnemyStates/Babosa/Idle")]
public class Babosa_Idle : EnemyState
{
    public override void OnStateEnter(EnemyBehaviour _behaviour)
    {
        timeStamp = Time.time;
        _behaviour.onHurt += OnHurt;
        float difficulty = Mathf.InverseLerp(_behaviour.ownHealth.maxHealth, 20, _behaviour.ownHealth.currentHealth);
        randCooldown = Random.Range((1.2f - difficulty) * 3f, (1.2f - difficulty) * 5f);
    }

    public override void OnStateExit(EnemyBehaviour _behaviour)
    {
        _behaviour.onHurt -= OnHurt;
    }

    private float timeStamp;
    private float numRand;
    private float randCooldown;

    public override void OnStateUpdate(EnemyBehaviour _behaviour)
    {
        if(Time.time > timeStamp + randCooldown)
        {
            _behaviour.ChangeState(_behaviour.attack);
        }
    }

    void OnHurt(HitData _hitData, EnemyBehaviour _behaviour)
    {
        Debug.Log("Idle on hurt");
        _behaviour.ChangeState(_behaviour.hurt);
    }
}
