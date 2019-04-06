using UnityEngine;

[RequireComponent(typeof(Health))]
public class DamageHandler : MonoBehaviour
{
    Health health;

    void Start()
    {
        health = GetComponent<Health>();
    }

    public void DoDamage(int damage)
    {
        health.currentHealth = (int)Mathf.Clamp(health.currentHealth - damage, 0f, health.maxHealth);
    }
}
