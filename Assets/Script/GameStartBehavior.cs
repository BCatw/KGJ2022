using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartBehavior : StateMachineBehaviour
{
    [SerializeField] bool isStart;
    SoundController sound;
    
    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        if (isStart)
        {
            sound = SoundController.Instance();
            sound.PlaySFX(1);
        }
        animator.SetBool(AnimatorKey.isStart, isStart);
    }
}
