using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartBehavior : StateMachineBehaviour
{
    [SerializeField] bool isStart;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        animator.SetBool(AnimatorKey.isStart, isStart);
    }
}
