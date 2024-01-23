using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : Animations
{
    void Start()
    {
        _controller.OnMoveEvent += Animation;
    }

    public void Animation(Vector2 direction)
    {
        animator.SetBool("IsWalking", direction.magnitude > 0f);
    }
}
