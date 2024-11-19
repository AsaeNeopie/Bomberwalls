using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PathfindingOptimized : MonoBehaviour
{
    [SerializeField] private int gridWidth = 10;
    [SerializeField] private int gridHeight = 10;
    [SerializeField] private int cellWidth = 1;
    [SerializeField] private int cellHeight = 1;
    [SerializeField] private bool generatPath;
    [SerializeField] private bool visualiseGrid;
    [SerializeField] private Cell cell;
    private Dictionary<Vector2, Cell> cells;

    bool pathGenerated;
    private void Update()
    {
        if (generatPath && !pathGenerated)
        {
            GenerateGrid();
            pathGenerated = true;
        }
        else if (!generatPath)
        {
            pathGenerated = false;
        }

    }

    private void GenerateGrid()
    {
        cells = new Dictionary<Vector2, Cell>();

        for (float x = 0; x < gridWidth; x += cellWidth)
        {
            for (float y = 0; y < gridHeight; y += cellHeight)
            {
                Vector2 pos = new Vector2(x, y);
                cells.Add(pos, new Cell(pos));
            }
        }
        for (int i = 0; i < 40; i++)
        {
            Vector2 pos = new Vector2(Random.Range(0, gridWidth), Random.Range(0, gridHeight));
            cells[pos].isWall = true;
        }
    }


    private void OnDrawGizmos()
    {
        if (!visualiseGrid || cells == null)
        {
            return;
        }

        foreach (KeyValuePair<Vector2, Cell> kvp in cells)
        {
            if (!kvp.Value.isWall)
            {
                Gizmos.color = Color.white;
            }
            else
            {
                Gizmos.color = Color.black;
            }

            Gizmos.DrawCube(kvp.Key + (Vector2)transform.position, new Vector3(cellWidth, cellHeight));
        }
    }
}
