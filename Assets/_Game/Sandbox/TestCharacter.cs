using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacter : MonoBehaviour
{
    bool moving = false;

    float timer = 1f;

    public int column = 0; //X
    public int row = 0; //Y

    IEnumerator Start()
    {
        yield return null;
        moving = true;
        transform.position = MapManager.instance.currentMap.GetTile(column, row).transform.position;
    }

    void Update()
    {
        if(moving)
        {
            timer += Time.deltaTime;
            if(timer > 1f)
            {
                timer = 0f;
                column++;
                if (column >= GridMap.width)
                {
                    column = 0;
                    row++;
                    if (row >= GridMap.height)
                    {
                        row = 0;
                    }
                }
                transform.position = MapManager.instance.currentMap.GetTile(column, row).transform.position;
            }
        }
    }
}
