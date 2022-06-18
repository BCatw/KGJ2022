using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] bool isControlable = false;
    public Animator animator;
    string aniKeyNext = "Next";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isControlable) animator.SetTrigger(aniKeyNext);
    }

    public void SwitchControllable()
    {
        isControlable = !isControlable;
    }
}
