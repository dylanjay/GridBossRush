using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Side
{
    Left, Right
}

public class GridMap : MonoBehaviour
{
    public string MapName;

    [SerializeField]
    GameObject[] grid;
    //[SerializeField]
    //GameObject[] gridRight;

    //TODO either a dictionary holding pieces in each grid spot or a reference to the actors in the grid spots

    public const int WIDTH = 6;
    public const int HEIGHT = 3;

    //void Start()
    //{
        
    //}

    public Transform GetTileTransform(/*Side side, */int column, int row)
    {
        int index = Convert2Dto1D(row, column);
        return /*side == Side.Left ? */grid[index].transform;// : gridRight[index].transform;
    }

    public Vector3 GetTilePosition(/*Side side, */int column, int row)
    {
        int index = Convert2Dto1D(row, column);
        return /*side == Side.Left ? */grid[index].transform.position;// : gridRight[index].transform.position;
    }

    int Convert2Dto1D(int column, int row)
    {
        row = Mathf.Clamp(row, 0, HEIGHT - 1);
        column = Mathf.Clamp(column, 0, WIDTH - 1);
        return column * WIDTH + row;
    }
}
