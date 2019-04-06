using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacter : MonoBehaviour
{
    bool moving = false;

    IEnumerator Start()
    {
        yield return null;
        moving = true;
        //transform.position = MapManager.instance.currentMap.GetTilePosition(0, 0);
    }

    float timer = 1f;

    public int row = 0;
    public int column = 0;

    void Update()
    {
        if(moving)
        {
            timer += Time.deltaTime;
            if(timer > 1f)
            {
                timer = 0f;
                transform.position = MapManager.instance.currentMap.GetTilePosition(row, column);
                row++;
                if (row >= GridMap.HEIGHT)
                {
                    row = 0;
                    column++;
                    if (column >= GridMap.WIDTH)
                    {
                        column = 0;

                    }
                }
            }
        }
    }
}
