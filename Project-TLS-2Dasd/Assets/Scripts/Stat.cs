using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stat
{
    [SerializeField] int baseValue;
    public int Value
    {
        get { return CalculateFinalValue(); }
    }
    public List<StatModifier> modifiers;

    public int CalculateFinalValue()
    {
        int finalValue = baseValue;

        foreach (StatModifier mod in modifiers)
        {
            baseValue += mod.value;
        }

        return finalValue;
    }
}
