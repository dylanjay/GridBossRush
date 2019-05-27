using UnityEngine;

public class ProjectileDestroyer : MonoBehaviour
{
    public LayerMask projectileLayer;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (1 << collision.gameObject.layer == projectileLayer.value)
        {
            // TODO : convert to pooling
            ObjectPoolManager.Recycle(collision.gameObject);
        }
    }
}
