using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellDatabase : Singleton<SpellDatabase>
{
    [SerializeField]
    SpellList spellList;

    Dictionary<string, Spell> spellDict = new Dictionary<string, Spell>();

    void FillDict()
    {
        if (spellList == null)
        {
            Debug.LogError("Spell List is null in database");
            return;
        }
        spellDict.Clear();
        for (int i = 0; i < spellList.spells.Count; i++)
        {
            spellDict.Add(spellList.spells[i].name.ToLower(), spellList.spells[i]);
        }
    }

    public Spell Get(string name)
    {
        if (spellDict.Count != spellList.spells.Count)
        {
            FillDict();
        }

        name = name.ToLower();
        if (!spellDict.ContainsKey(name))
        {
            Debug.LogError("Spell does not exist in database");
            return null;
        }

        return spellDict[name];
    }
}
