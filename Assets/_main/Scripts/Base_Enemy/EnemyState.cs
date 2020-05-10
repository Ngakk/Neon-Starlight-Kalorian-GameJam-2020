using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyState : ScriptableObject
{
    public abstract void OnStateEnter(EnemyBehaviour _behaviour);
    public abstract void OnStateExit(EnemyBehaviour _behaviour);
    public abstract void OnStateUpdate(EnemyBehaviour _behaviour);
}
