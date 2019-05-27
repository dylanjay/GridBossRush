using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpell : Spell
{
    public GameObject fireballPrefab;
    public int damage;
    public Vector2 startOffset;
    public Vector2 direction;
    public float speed;
    public LayerMask hitLayer;

    void Start()
    {
        ObjectPoolManager.CreatePool(fireballPrefab, 10);
    }

    public override void Activate()
    {
        GameObject fireball = ObjectPoolManager.Spawn(fireballPrefab, Player.instance.transform.position + (Vector3)startOffset + Vector3.up * Player.instance.GetComponent<BoxCollider2D>().size.y / 2);
        fireball.GetComponent<Fireball>().Initialize(damage, direction, speed, hitLayer);
    }
}
