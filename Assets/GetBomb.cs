using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBomb : MonoBehaviour
{
    [SerializeField] Inventory _inventory;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Bomb" && !_inventory.BombInInventory)
        {
            Debug.Log("u");
            _inventory.Bomb.Add(other.gameObject);
            other.gameObject.SetActive(false);
            _inventory.BombInInventory = true;
            Debug.Log(_inventory.BombInInventory);
        }
    }
}
