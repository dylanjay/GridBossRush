using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : Spell
{
    public Vector2 location;

    public override void Activate()
    {
        //TODO : make dictionary from Vector3 to index
        Player.instance.GetComponent<PlayerLocation>().x = Mathf.Clamp(Player.instance.GetComponent<PlayerLocation>().x + (int)location.x, 0, GridMap.HEIGHT - 1);
        Player.instance.GetComponent<PlayerLocation>().y = Mathf.Clamp(Player.instance.GetComponent<PlayerLocation>().y + (int)location.y, 0, GridMap.WIDTH - 1);
        Player.instance.transform.position = MapManager.instance.currentMap.GetTilePosition(Player.instance.GetComponent<PlayerLocation>().x, Player.instance.GetComponent<PlayerLocation>().y);
    }
}
