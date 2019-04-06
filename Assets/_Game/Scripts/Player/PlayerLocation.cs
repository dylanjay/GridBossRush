using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocation : MonoBehaviour
{
    public int x;
    public int y;

    void Start()
    {
        transform.position = MapManager.instance.currentMap.GetTilePosition(x, y);
    }

    public void Set(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
