using UnityEngine;

public class MoveSpell : Spell
{
    public Vector2 direction;

    public override void Activate()
    {
        Player.instance.GetComponent<PlayerLocation>().Move(Player.instance.GetComponent<PlayerLocation>().tile.x + (int)direction.x, Player.instance.GetComponent<PlayerLocation>().tile.y + (int)direction.y);
    }
}
