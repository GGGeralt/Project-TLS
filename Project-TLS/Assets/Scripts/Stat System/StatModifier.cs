using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatModifierType
{
    Flat
}

[Serializable]
public class StatModifier
{
    public StatModifierType Type;
    public int value;
}
