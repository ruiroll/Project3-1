using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    protected Animator animator;
    protected CharController _controller;

    protected virtual void Awake()
    {
        _controller = GetComponent<CharController>();
        animator = GetComponentInChildren<Animator>();
    }
}
