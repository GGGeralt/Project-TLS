using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Ability : ScriptableObject
{
    public string description;
    public float cooldown;
    public virtual void Use(GameObject caster)
    {
        Debug.Log($"Ability [{name}] has been used");
    }
}
