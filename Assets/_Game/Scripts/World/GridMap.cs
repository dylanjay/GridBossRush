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

    public Transform GetTileTransform(/*Side side, */int row, int column)
    {
        int index = Convert2Dto1D(row, column);
        return /*side == Side.Left ? */grid[index].transform;// : gridRight[index].transform;
    }

    public Vector3 GetTilePosition(/*Side side, */int row, int column)
    {
        int index = Convert2Dto1D(row, column);
        return /*side == Side.Left ? */grid[index].transform.position;// : gridRight[index].transform.position;
    }

    int Convert2Dto1D(int row, int column)
    {
        return row * WIDTH + column;
    }
}
