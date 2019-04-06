using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int row;
    int column;

    IEnumerable Start()
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
            while(nextRow != -1 && nextColumn != -1 && tries < 20)
            {
                int horizontalOrVertical = Random.Range(0, 2);
                if(horizontalOrVertical == 0)
                {
                    int leftOrRight = Random.Range(0, 2);
                    if(leftOrRight == 0)
                    {
                        column--;
                        if (column >= 0)
                        {
                            nextColumn = 0;
                        }
                    }
                }
                else
                {
                    int upOrDown = Random.Range(0, 2);
                }
                tries++;
            }
        }
    }
}
