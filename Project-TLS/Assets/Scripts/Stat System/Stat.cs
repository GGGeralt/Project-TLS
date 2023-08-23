using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat
{
    public float value;
    public List<StatModifier> modifiers;

    public float CalculateFinalValue()
    {
        float finalValue = value;
        foreach (StatModifier statMod in modifiers)
        {
            finalValue += statMod.value;
        }

        return finalValue;
    }
}
