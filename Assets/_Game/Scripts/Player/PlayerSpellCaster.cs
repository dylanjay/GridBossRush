using System.Collections.Generic;
using UnityEngine;

public class PlayerSpellCaster : MonoBehaviour
{
    Dictionary<string, Spell> spellBook = new Dictionary<string, Spell>();

    public Transform spellsParent;

    void Awake()
    {
        FillBook();
    }

    void FillBook()
    {
        for (int i = 0; i < spellsParent.childCount; i++)
        {
            Transform spellTransform = spellsParent.GetChild(i);
            if (spellTransform.GetComponent<Spell>())
            {
                Spell spell = spellTransform.GetComponent<Spell>();
                spellBook.Add(spell.spellName, spell);
            }
        }
    }

    public void CastSpell(string spellName)
    {
        if (!spellBook.ContainsKey(spellName))
        {
            return;
        }
        spellBook[spellName].Activate();
    }
}
