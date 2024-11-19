using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 _movementInput;
    [SerializeField] float _speed;
     Rigidbody2D _rb;
    [SerializeField] Inventory _inventory;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        _movementInput = context.ReadValue<Vector2>();
        if (context.performed)
        {
            transform.Translate(_movementInput * _speed * Time.deltaTime);
        }
    }
    public void OnFire(InputAction.CallbackContext context)
    {   
            if (context.performed && _inventory.BombInInventory)
        {

            _inventory.gameObject.SetActive(true); 
            gameObject.transform.position = this.transform.position;
            _inventory.Bomb.Clear();
            _inventory.BombInInventory = false;    
        }
                
    }
}
