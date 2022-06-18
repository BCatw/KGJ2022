using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScriptBehavior : StateMachineBehaviour
{
    [SerializeField] int loadIndex;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        DialogueWriter writer = DialogueWriter.Writer();
        writer.LoadData(loadIndex);
    }
}
