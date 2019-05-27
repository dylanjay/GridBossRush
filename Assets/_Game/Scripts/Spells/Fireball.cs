using UnityEngine;

public class Fireball : MonoBehaviour
{
    Animator animator;

    int damage;
    LayerMask hitLayer;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Initialize(int damage, Vector2 direction, float speed, LayerMask hitLayer)
    {
        this.damage = damage;
        this.hitLayer = hitLayer;
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
