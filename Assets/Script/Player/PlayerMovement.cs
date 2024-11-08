using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
                       
            _horizontal += context.ReadValue<Vector2>().y;
            _vertical += context.ReadValue<Vector2>().x;
            transform.position *= _horizontal;
            transform.position *= _vertical;

            Debug.Log(context.ReadValue<Vector2>());
        }
    }
}
