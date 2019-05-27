using System;
using UnityEngine;

public enum GridSide
{
    Left, Right
}

public class GridMap : MonoBehaviour
{
    GridTile[][] grid;

    public string MapName;

    [SerializeField]
    GameObject[] gridTileGos;
    //[SerializeField]
    //GameObject[] gridRight;

    //TODO either a dictionary holding pieces in each grid spot or a reference to the actors in the grid spots

    public const int width = 6;
    public const int height = 3;

    void Awake()
    {
        if (gridTileGos.Length < width * height)
        {
            Debug.LogError("Not enough gridTileGOs in gridMap");
            return;
        }

        grid = new GridTile[width][];
        FillGrid();
    }

    private void FillGrid()
    {
        int tileIndex = 0;
        for (int i = 0; i < width; i++)
        {
            grid[i] = new GridTile[height];
            for (int j = 0; j < height; j++)
            {
                grid[i][j] = gridTileGos[tileIndex++].GetComponent<GridTile>();
                grid[i][j].x = i;
                grid[i][j].y = j;
            }
        }
    }

    public GridTile GetTile(/*GridSide side, */int x, int y)
    {
        x = Mathf.Clamp(x, 0, width - 1);
        y = Mathf.Clamp(y, 0, height - 1);
        return grid[x][y];
    }

    public GridTile Move(int x, int y)
    {
        GridTile to = GetTile(x, y);
        return to;
    }

    public GridTile Move(GridTile from, int x, int y)
    {
        GridTile to = GetTile(x, y);
        if (!to.moveable)
        {
            return from;
        }

        if (to != from)
        {
            to.Enter();
            from.Exit();
        }
       return to;
    }
}
