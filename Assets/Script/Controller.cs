using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] bool isControlable = false;
    public Animator animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isControlable) animator.SetTrigger(AnimatorKey.Next);
    }

    public void SwitchControllable()
    {
        isControlable = !isControlable;
    }
}
