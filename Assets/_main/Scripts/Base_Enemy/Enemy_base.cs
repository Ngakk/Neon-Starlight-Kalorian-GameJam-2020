using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState {
    NO_DAMAGE,
    TAKE_DAMAGE,
    PATRON,    
}

[RequireComponent(typeof(Enemy_Movement))]
[RequireComponent(typeof(Enemy_Actions))]
[RequireComponent(typeof(Animator))]
public class Enemy_base : MonoBehaviour
{
    public EnemyState mystate;
    public float moveSpeed;
    public bool isSearching = true;
    public bool isAtacking = false;
    public bool isMoving = false;
    private Enemy_Actions enemy_Actions;
    private Enemy_Movement enemy_Movement;
    public GameObject player;

    private void Start() 
    {
        enemy_Actions = GetComponent<Enemy_Actions>();
        enemy_Movement = GetComponent<Enemy_Movement>();
        enemy_Movement.speedagent = moveSpeed;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Loot de esto: " +  enemy_Actions.DropLoot().name);
        }
        GetValueActions();
        ProcessActions();
    }

    private void GetValueActions()
    {
        if(Vector2.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(player.transform.position.x, player.transform.position.z)) < 5.0f && isSearching)
        {
            isSearching = false;
            isMoving = true;
        }
        else if(Vector2.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(player.transform.position.x, player.transform.position.z)) < 0.2f)
        {
            isAtacking = true;
        }
        else
        {
            isSearching = true;
            isAtacking = false;
        }
    }

    private void ProcessActions()
    {
        if(isMoving)
        {
            enemy_Movement.MoveCharacter(player.transform);
            isMoving = false;
        }
        if(isAtacking)
        {
            enemy_Actions.Attack();
        }
    }
}
