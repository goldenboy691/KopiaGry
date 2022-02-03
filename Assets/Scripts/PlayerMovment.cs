using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovment : MonoBehaviour
{
    private Vector2 moveInput;

    void PhysicsUpdate()
    {

    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}