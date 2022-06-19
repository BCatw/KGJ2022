using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBehavior : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        DialogueWriter writer = DialogueWriter.Writer();
        if (writer.CheckIsOver()) animator.SetTrigger(AnimatorKey.Next);
        else animator.SetInteger(AnimatorKey.dataIndex, writer.GetDataIndex() + 1);
    }
}
