using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] private Vector2 _position;
    [SerializeField] private Vector2 _connection;
    [SerializeField] private int _fCost;
    [SerializeField] private int _gCost;
    [SerializeField] private int _hCost;
    [SerializeField] public bool isWall;

    public Cell(Vector2 pos)
    {
        _position = pos;
    }
}   
