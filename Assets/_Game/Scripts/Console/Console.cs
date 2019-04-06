using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    [SerializeField]
    Text textUI;

    void Update()
    {
        string inputString = Input.inputString;
        for (int i = 0; i < inputString.Length; i++)
        {
            char c = inputString[i];
            //end of command characters
            if (c == ' ' || c == '\t' || c == '\n' || c == '\r')
            {
                CastSpell();
                textUI.text = string.Empty;
            }
            else if (c == '\b' && textUI.text.Length > 0)
            {
                string newString = textUI.text.Remove(textUI.text.Length - 1);
                textUI.text = newString;
            }
            else if ((c >= 'a' && c <= 'z') ||
                     (c >= 'A' && c <= 'Z') ||
                     (c >= '0' && c <= '9'))
            {
                textUI.text += c;
            }
        }
    }

    void CastSpell()
    {
        string spellName = textUI.text;
        Spell spell = SpellDatabase.instance.Get(spellName);
        if (spell != null)
        {
            TWDebug.Log("Cast", spell.name);
            spell.Activate();
        }
    }
}
