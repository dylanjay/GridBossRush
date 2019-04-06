using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    public new string name;
    public abstract void Activate();
}
