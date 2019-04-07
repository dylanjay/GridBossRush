using UnityEngine;

public class Fireball : Spell
{
    Animator animator;

    public int damage;
    public Vector2 startOffset;
    public Vector2 direction;
    public float speed;
    public LayerMask hitLayer;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public override void Activate()
    {
        transform.position = Player.instance.transform.position + (Vector3)startOffset + Vector3.up * Player.instance.GetComponent<BoxCollider2D>().size.y / 2;
        GetComponent<Rigidbody2D>().velocity = direction.normalized * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (Utilities.LayerCollision(collision.gameObject, hitLayer))
        {
            collision.GetComponent<DamageHandler>().DoDamage(damage);
            animator.SetTrigger("Break");
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            GetComponent<CircleCollider2D>().enabled = false;
        }
    }
}
