using UnityEngine;

public class Health : MonoBehaviour
{
    [HideInInspector]
    public int currentHealth;
    public int maxHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }
}
