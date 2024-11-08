using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomScript : MonoBehaviour
{
    public event Action<int> HpChange;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject);
        if (other.tag == "Wall") 
        { 
            other.gameObject.GetComponent<WallHp>().Hp --;
            
            Debug.Log(other.gameObject.GetComponent<WallHp>().Hp);
        }
    }

}
