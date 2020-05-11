using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetpAnimationSync : StateMachineBehaviour
{
    public int stepFrameInterval;
    public int frameRate = 24;

    private static float walkTimeExit;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        while(walkTimeExit > stateInfo.length)
        {
            walkTimeExit -= stateInfo.length;
        }

        animator.SetFloat("WalkCycleOffset", walkTimeExit);
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        walkTimeExit = stateInfo.normalizedTime * stateInfo.length;
    }
}
