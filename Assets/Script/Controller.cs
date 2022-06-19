using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public enum switchFunc {reverse, on, off };
    [SerializeField] bool isControlable = false;
    [SerializeField] string buttonKey = "Fire1";
    public Animator animator;

    void Update()
    {
        if (Input.GetButton(buttonKey) && isControlable) animator.SetTrigger(AnimatorKey.Next);
    }

    public void SwitchControllable(switchFunc switchFunc)
    {
        switch (switchFunc) {
            case switchFunc.reverse:
            isControlable = !isControlable;
                break;
            case switchFunc.on:
                isControlable = true;
                break;
            case switchFunc.off:
                isControlable = false;
                break;
            default:
                return;
        }
    }
}
