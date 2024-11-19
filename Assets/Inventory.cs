using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool BombInInventory;
    public List<GameObject> Bomb;
    private void Awake()
    {
        BombInInventory = false;
    }


}
