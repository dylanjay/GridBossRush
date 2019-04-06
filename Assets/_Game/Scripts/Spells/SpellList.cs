using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpellList", menuName = "Spells/List/SpellList", order = 0)]
public class SpellList : ScriptableObject
{
    public List<Spell> spells = new List<Spell>();
}
