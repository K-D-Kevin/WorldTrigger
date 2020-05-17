using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerAnimationControl : MonoBehaviour
{
    [SerializeField]
    private Animator PlayerAnimatorScript;
    public Animator PlayerAnimator { get { return PlayerAnimatorScript; } }

    public void UpdateMovementParameters(Vector2 Inputs)
    {
        PlayerAnimatorScript.SetFloat("LinearMovement", Inputs.y);
        PlayerAnimatorScript.SetFloat("StrafeMovement", Inputs.x);
        if (Inputs.x > .2f || Inputs.x < -.2f)
        {
            PlayerAnimatorScript.SetBool("Strafing", true);
        }
        else
        {
            PlayerAnimatorScript.SetBool("Strafing", false);
        }

        if (Inputs.x == 0 && Inputs.y == 0)
        {
            PlayerAnimatorScript.SetTrigger("Idle");
        }
    }

    public void SetSprint(bool IsSprinting)
    {
        PlayerAnimatorScript.SetBool("Sprinting", IsSprinting);
    }

    public void TriggerPunch()
    {
        PlayerAnimatorScript.SetTrigger("Punch");
    }
}
