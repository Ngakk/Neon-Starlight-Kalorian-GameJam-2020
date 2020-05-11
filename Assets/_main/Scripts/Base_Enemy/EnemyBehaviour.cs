using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public delegate void EnemyBehaviourHurtEvent(HitData _hitData, EnemyBehaviour _behaviour);

public class EnemyBehaviour : MonoBehaviour
{
    [HideInInspector] public CharacterMovement characterMovement;
    [HideInInspector] public Health characterHealth;
    public Health ownHealth;
    public Hurtbox hurtbox;
    public Enemy_Actions enemyActions;
    public Animator animator;

    public EnemyState idle, attack, hurt, die;

    public UnityEvent onAttackUEvent, onHurtUEvent, onDieUEvent;
    public EnemyBehaviourHurtEvent onHurt;

    [SerializeField] private EnemyState currentState;

    private void OnEnable()
    {
        hurtbox.onHurtLate += OnHurt;
    }

    private void OnDisable()
    {
        hurtbox.onHurtLate -= OnHurt;
    }

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

    void OnHurt(HitData _hitData)
    {
        Debug.Log("Enemy On Hurt");
        onHurt?.Invoke(_hitData, this);
    }
}
