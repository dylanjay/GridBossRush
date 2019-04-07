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
            // end of command characters
            if ((c == '\t' || c == '\n' || c == '\r') ||
                (c == ' ' && Input.GetKey(KeyCode.LeftShift)))
            {
                CastSpell(textUI.text);
                textUI.text = string.Empty;
            }
            // single key hotkeys
            else if (c >= 'A' && c <= 'Z')
            {
                CastSpell(c.ToString());
            }
            // delete char hotkeys
            else if (c == '\b' && textUI.text.Length > 0)
            {
                // if holding shift clear console
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    textUI.text = string.Empty;
                }
                // remove one char
                else
                {
                    string newString = textUI.text.Remove(textUI.text.Length - 1);
                    textUI.text = newString;
                }
            }
            // rest of chars
            else if ((c >= 'a' && c <= 'z') ||
                     (c >= '0' && c <= '9') ||
                     (c == ' '))
            {
                textUI.text += c;
            }
        }
    }

    void CastSpell(string spellName)
    {
        SpellData spellData = SpellDatabase.instance.Get(spellName);
        if (spellData != null)
        {
            Spell spell = Instantiate(spellData.prefab).GetComponent<Spell>();
            spell.Activate();
        }
    }
}
