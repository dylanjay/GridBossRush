using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(InputField))]
public class Console : MonoBehaviour
{
    InputField inputField;

    void Awake()
    {
        inputField = GetComponent<InputField>();
    }

    void Start()
    {
        inputField.Select();
        inputField.ActivateInputField();
    }

    public void Input()
    {
        string spellName = inputField.text;
        Spell spell = SpellDatabase.instance.Get(spellName);
        if (spell != null)
        {
            TWDebug.Log("Cast", spellName);
            spell.Activate();
        }
        inputField.text = string.Empty;
        inputField.Select();
        inputField.ActivateInputField();
    }
}
