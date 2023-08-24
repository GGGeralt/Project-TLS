using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AbilityType
{
    Skillshot,
}

[Serializable]
public class Ability : ScriptableObject
{
    public AbilityType type;
    public string description;
    public float cooldown = 5;
    public float cooldownTimer = 0;
    public virtual void Use(GameObject caster)
    {
        Debug.Log($"Ability [{name}] has been used");
    }
}
