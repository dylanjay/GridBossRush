﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int row = 1;
    public int column = 3;

    IEnumerator Start()
    {
        yield return null;
        yield return null;
        transform.position = MapManager.instance.currentMap.GetTilePosition(row, column);
    }

    float movementDelay = 1.5f;
    float timer = 0f;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > movementDelay)
        {
            timer = 0f;
            int nextRow = -1;
            int nextColumn = -1;
            int tries = 0;
            while(nextRow == -1 && nextColumn == -1 && tries < 20)
            {
                int horizontalOrVertical = Random.Range(0, 2);
                if(horizontalOrVertical == 0)
                {
                    int leftOrRight = Random.Range(0, 2);
                    if(leftOrRight == 0) //Left
                    {
                        if (column - 1 >= 3)
                        {
                            nextColumn = column - 1;
                            nextRow = row;
                        }
                    }
                    else //Right
                    {
                        if (column + 1 < GridMap.WIDTH)
                        {
                            nextColumn = column + 1;
                            nextRow = row;
                        }
                    }
                }
                else
                {
                    int upOrDown = Random.Range(0, 2);
                    if (upOrDown == 0) //Up
                    {
                        if (row - 1 >= 0)
                        {
                            nextColumn = column;
                            nextRow = row - 1;
                        }
                    }
                    else //Down
                    {
                        if (row + 1 < GridMap.HEIGHT)
                        {
                            nextColumn = column;
                            nextRow = row + 1;
                        }
                    }
                }
                tries++;
            }
            row = nextRow;
            column = nextColumn;
            transform.position = MapManager.instance.currentMap.GetTilePosition(row, column);
        }
    }
}
