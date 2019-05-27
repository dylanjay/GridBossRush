using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    public string spellName;
    public abstract void Activate();
}
