using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState {
    NO_DAMAGE,
    TAKE_DAMAGE,
    PATRON,    
}

[RequireComponent(typeof(Enemy_Actions))]
[RequireComponent(typeof(Animator))]
public class Enemy_base : MonoBehaviour
{
    public int Life;
    public EnemyState mystate;
    private Enemy_Actions enemy_Actions;
    public GameObject player;

    private void Start() 
    {
        enemy_Actions = GetComponent<Enemy_Actions>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update() 
    {
        GetValueActions();
        ProcessActions();
    }

    private void GetValueActions()
    {
        
    }

    private void ProcessActions()
    {
        
    }
}
