using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyBehaviour : MonoBehaviour
{
    [HideInInspector] public CharacterMovement characterMovement;
    [HideInInspector] public Health characterHealth;
    public Health ownHealth;
    public Hurtbox hurtbox;
    public Enemy_Actions enemyActions;
    public Animator animator;

    public EnemyState idle, attack, hurt, die;

    public UnityEvent onAttack, onHurt, onDie;

    private EnemyState currentState;

    private void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        if(go)
        {
            characterMovement = go.GetComponent<CharacterMovement>();
            characterHealth = go.GetComponent<Health>();
        }
        ChangeState(idle);
    }

    private void Update()
    {
        currentState.OnStateUpdate(this);
    }

    public void ChangeState(EnemyState _state)
    {
        currentState?.OnStateExit(this);
        currentState = _state;
        currentState.OnStateEnter(this);
    }
}
