using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stat
{
    public int value;
    public List<StatModifier> modifiers;

    public int CalculateFinalValue()
    {
        int finalValue = value;
        foreach (StatModifier statMod in modifiers)
        {
            finalValue += statMod.value;
        }

        return finalValue;
    }
}
