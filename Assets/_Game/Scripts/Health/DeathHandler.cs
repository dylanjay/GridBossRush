using UnityEngine;
using System;

public class DeathHandler : MonoBehaviour
{
    public event Action OnDieEvent;

    public void Die()
    {
        OnDieEvent();
    }
}
