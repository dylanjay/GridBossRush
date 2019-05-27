using UnityEngine;

[CreateAssetMenu(fileName = "Teleport", menuName = "Spells/Teleport", order = 2)]
public class Teleport : Spell
{ 
    public Vector2 location;

    public override void Activate()
    {
        //TODO : make dictionary from Vector3 to index
        //Player.instance.GetComponent<PlayerLocation>().x = Mathf.Clamp(Player.instance.GetComponent<PlayerLocation>().x + (int)location.x, 0, GridMap.height - 1);
        //Player.instance.GetComponent<PlayerLocation>().y = Mathf.Clamp(Player.instance.GetComponent<PlayerLocation>().y + (int)location.y, 0, GridMap.width - 1);
        //Player.instance.transform.position = MapManager.instance.currentMap.GetTile(Player.instance.GetComponent<PlayerLocation>().x, Player.instance.GetComponent<PlayerLocation>().y).transform.position;
        Player.instance.GetComponent<PlayerLocation>().Move((int)location.x, (int)location.y);
        Destroy(gameObject);
    }
}
