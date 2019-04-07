using UnityEngine;

[CreateAssetMenu(fileName = "Spell", menuName = "Spells/Spell", order = 0)]
public class SpellData : ScriptableObject
{
    public string spellName;
    public GameObject prefab;
}
