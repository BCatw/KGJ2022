using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] bool isControlable = false;
    [SerializeField] string buttonKey = "Fire1";
    public Animator animator;

    void Update()
    {
        if (Input.GetButton(buttonKey) && isControlable) animator.SetTrigger(AnimatorKey.Next);
    }

    public void SwitchControllable()
    {
        isControlable = !isControlable;
    }
}
