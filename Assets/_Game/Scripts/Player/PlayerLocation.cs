using UnityEngine;

public class PlayerLocation : MonoBehaviour
{
    [HideInInspector]
    public GridTile tile;

    public Vector2 startPos;

    void Start()
    {
        tile = MapManager.instance.currentMap.Move((int)startPos.x, (int)startPos.y);
        transform.position = tile.transform.position;
    }

    public void Move(int x, int y)
    {
        tile = MapManager.instance.currentMap.Move(tile, tile.x + x, tile.y + y);
        transform.position = tile.transform.position;
    }
}
