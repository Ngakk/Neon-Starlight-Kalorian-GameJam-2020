using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class Enemy_Movement : MonoBehaviour
{
    private NavMeshAgent agent;
    [HideInInspector]
    public float speedagent;

    private void Start() 
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speedagent;
    }

    public void MoveCharacter(Transform _goal)
    {
        agent.destination = _goal.position;
    }
}
