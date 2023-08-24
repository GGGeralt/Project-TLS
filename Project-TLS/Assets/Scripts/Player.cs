using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : Creature
{
    public static Player Instance { get; private set; }
    public Ability ability;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UseSkill(ability);
        }

        ability.cooldownTimer = Mathf.Clamp(ability.cooldownTimer - Time.deltaTime, 0, ability.cooldown);
    }

    void UseSkill(Ability ability)
    {
        if (ability.cooldownTimer == 0)
        {
            ability.Use(gameObject);
            ability.cooldownTimer = ability.cooldown;
        }
    }
    private void OnGUI()
    {
        GUI.TextArea(new Rect(50, 50, 100, 100), ability.cooldownTimer.ToString());
    }
}
