using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellDatabase : Singleton<SpellDatabase>
{
    [SerializeField]
    SpellList spellList;

    Dictionary<string, Spell> spellDict = new Dictionary<string, Spell>();

    void Start()
    {
        FillDict();
    }

    void FillDict()
    {
        if (spellList == null)
        {
            Debug.LogError("Spell List is null in database");
            return;
        }
        spellDict.Clear();
        Debug.Log("Spells");
        for (int i = 0; i < spellList.spells.Count; i++)
        {
            spellDict.Add(spellList.spells[i].spellName.ToLower(), spellList.spells[i]);
            TWDebug.Log(spellList.spells[i].name, ":", spellList.spells[i].spellName.ToLower());
        }
    }

    public Spell Get(string name)
    {
        name = name.ToLower();
        if (!spellDict.ContainsKey(name))
        {
            return null;
        }

        return spellDict[name];
    }
}
