using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class StatChangeable
{
    public Stat maximumValue;
    public int currentValue;

    public void Increase(int value)
    {
        currentValue = Mathf.Clamp(currentValue + value, 0, maximumValue.value);
    }
}
