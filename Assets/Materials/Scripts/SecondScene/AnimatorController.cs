using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class AnimatorController: MonoBehaviour
{
    [Inject] private Animator _animator;

    public void AnimateWalking()
    {
        _animator.SetTrigger("Walk");
        _animator.ResetTrigger("Idle");
    }
    
    public void StopAnimateWalking()
    {
        _animator.ResetTrigger("Walk");
        _animator.SetTrigger("Idle");
    }
}
