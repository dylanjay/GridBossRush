using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpellList", menuName = "Spells/SpellList", order = 1)]
public class SpellList : ScriptableObject
{
    public List<SpellData> spells;
}
