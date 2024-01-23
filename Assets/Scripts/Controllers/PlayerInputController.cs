using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharController
{
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 local = value.Get<Vector2>();
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(local);
        Vector2 playerAim = (mousePos - (Vector2)transform.position).normalized;
        CallLookEvent(playerAim);
    }
}
