using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    private CharController _controller;
    [SerializeField] private SpriteRenderer characterRenderer;
    
    private void Awake() 
    {
        _controller = GetComponent<CharController>();
    }
    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 aimDirection)
    {
        float rotZ = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
