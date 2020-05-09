using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAttackStateMachineBehaviour : StateMachineBehaviour
{
    public CharacterMovement movement;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        if(movement == null)
        {
            movement = animator.GetComponent<CharacterMovement>();
        }

        movement.influence = 0;
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateExit(animator, stateInfo, layerIndex);
        if(movement.influence == 0)
            movement.influence = 1;
    }
}
