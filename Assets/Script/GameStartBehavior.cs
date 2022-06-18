using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartBehavior : StateMachineBehaviour
{
    [SerializeField] bool isStart;
    string aniKeyIsStarted = "isStarted";

    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        animator.SetBool(aniKeyIsStarted, isStart);
    }
}
