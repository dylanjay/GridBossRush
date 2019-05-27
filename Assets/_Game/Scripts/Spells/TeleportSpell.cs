using UnityEngine;

public class TeleportSpell : Spell
{ 
    public Vector2 location;

    public override void Activate()
    {
        Player.instance.GetComponent<PlayerLocation>().Move((int)location.x, (int)location.y);
    }
}
