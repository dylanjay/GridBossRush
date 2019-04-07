using System.Collections.Generic;
using UnityEngine;

public class SpellDatabase : Singleton<SpellDatabase>
{
    [SerializeField]
    SpellList spellList;

    Dictionary<string, SpellData> spellDict = new Dictionary<string, SpellData>();

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
            spellDict.Add(spellList.spells[i].spellName, spellList.spells[i]);
            TWDebug.Log(spellList.spells[i].name, ":", spellList.spells[i].spellName);
        }
    }

    public SpellData Get(string name)
    {
        if (!spellDict.ContainsKey(name))
        {
            return null;
        }

        return spellDict[name];
    }
}
