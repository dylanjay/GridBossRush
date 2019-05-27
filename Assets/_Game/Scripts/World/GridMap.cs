using System;
using UnityEngine;

public enum GridSide
{
    Left, Right
}

public class GridMap : MonoBehaviour
{
    GridTile[][] leftGrid;
    GridTile[][] rightGrid;

    public string MapName;

    [SerializeField]
    GameObject[] gridTileGos;
    //[SerializeField]
    //GameObject[] gridRight;

    //TODO either a dictionary holding pieces in each grid spot or a reference to the actors in the grid spots

    public const int numGrids = 2;
    public const int width = 3;
    public const int height = 3;

    void Awake()
    {
        if (gridTileGos.Length < width * height)
        {
            Debug.LogError("Not enough gridTileGOs in gridMap");
            return;
        }

        leftGrid = new GridTile[width][];
        rightGrid = new GridTile[width][]; 
        FillGrid();
    }

    private void FillGrid()
    {
        int tileIndex = 0;
        for (int gridNum = 0; gridNum < numGrids; gridNum++)
        {
            for (int i = 0; i < width; i++)
            {
                if (gridNum == 0)
                {
                    leftGrid[i] = new GridTile[height];
                    for (int j = 0; j < height; j++)
                    {
                        leftGrid[i][j] = gridTileGos[tileIndex++].GetComponent<GridTile>();
                        leftGrid[i][j].x = i;
                        leftGrid[i][j].y = j;
                    }
                }
                else if (gridNum == 1)
                {
                    rightGrid[i] = new GridTile[height];
                    for (int j = 0; j < height; j++)
                    {
                        rightGrid[i][j] = gridTileGos[tileIndex++].GetComponent<GridTile>();
                        rightGrid[i][j].x = i;
                        rightGrid[i][j].y = j;
                    }
                }
            }
        }
    }

    public GridTile GetTile(GridSide side, int x, int y)
    {
        x = Mathf.Clamp(x, 0, width - 1);
        y = Mathf.Clamp(y, 0, height - 1);
        if (side == GridSide.Left)
        {
            return leftGrid[x][y];
        }
        else
        {
            return rightGrid[x][y];
        }
    }

    public GridTile Move(GridSide side, int x, int y)
    {
        GridTile to = GetTile(side, x, y);
        return to;
    }

    public GridTile Move(GridSide side, GridTile from, int x, int y)
    {
        GridTile to = GetTile(side, x, y);
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
